Selenium.prototype.isTextPresentXML = function(pattern) {
  /**
   * Verifies that the specified text pattern appears somewhere in the entire XML document
   * (as opposed to text only within &lt;body/&gt; tags).
   * Note that when defining text patterns in your test case you should
   * escape HTML characters. For example: <td>&lt;userInRole&gt;</td>
   * (not <td><userInRole></td>).
   * @param pattern a <a href="#patterns">pattern</a> to match with the text of the document
   * @return boolean true if the pattern matches the text, false otherwise
   * File from the selenium project
   */

    // the only code that differs from the stock Selenium isTextPresent
    //	is the code to retrieve allText...
    // IE
    var allText = this.browserbot.getDocument().xml;
    if (allText == null) {
    	// Firefox
    	allText = new XMLSerializer().serializeToString(this.browserbot.getDocument());
    }

    var patternMatcher = new PatternMatcher(pattern);
    if (patternMatcher.strategy == PatternMatcher.strategies.glob) {
            if (pattern.indexOf("glob:")==0) {
                    pattern = pattern.substring("glob:".length); // strip off "glob:"
                }
        patternMatcher.matcher = new PatternMatcher.strategies.globContains(pattern);
    }
    else if (patternMatcher.strategy == PatternMatcher.strategies.exact) {
                pattern = pattern.substring("exact:".length); // strip off "exact:"
        return allText.indexOf(pattern) != -1;
    }
    return patternMatcher.matches(allText);
};