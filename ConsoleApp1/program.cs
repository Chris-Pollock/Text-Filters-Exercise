using TextFilter;

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