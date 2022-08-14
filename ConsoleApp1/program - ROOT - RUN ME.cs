using TextFilter;

// few notes:
// no longer agree to split on space in FilterTextByFilters.cs to gain each word. Would process character by character.
// also skipped handling punctuation, so punctuation is counted as part of the word. Would need to change that at the same time. This also includes line breaks so handles funny with that.

// never got around to applying unit tests. Haven't done much unit testing in c# to be frank so skipped for the sake of this exercise and just tried to get as far as possible in 2 hours.

var text = FileReader.readStringFromFile(@".\Text.txt");
TextFilterByLength filterbyLessThan3 = new TextFilterByLength(2);
TextFilterByContainingCharacter filterByContainingT = new TextFilterByContainingCharacter('t');
TextFilterByVowelInMiddle filterByVowelInMiddle = new TextFilterByVowelInMiddle();
List<ITextFilter> textFilters = new List<ITextFilter>();
textFilters.Add(filterbyLessThan3);
textFilters.Add(filterByContainingT);
textFilters.Add(filterByVowelInMiddle);
FilterTextByFilters filterTextByFilters = new FilterTextByFilters(textFilters);
TestStringAgainstFilters testStringAgainstFilters = new TestStringAgainstFilters();
Console.WriteLine(filterTextByFilters.filterStringByFilters(text, testStringAgainstFilters));