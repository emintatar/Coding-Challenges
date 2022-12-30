
// Given a string, return a new string where the last 3 chars are now in upper case. If the string has less than 3 chars, uppercase whatever is there. Note that str.toUpperCase() returns the uppercase version of a string.


// endUp("Hello") → "HeLLO"
// endUp("hi there") → "hi thERE"
// endUp("hi") → "HI"

public String endUp(String str) 
{
  if (str.length() > 2)
  {
    String first = str.substring(0, str.length() - 3);
    String last = str.substring(str.length() - 3, str.length());
    return first + last.toUpperCase();
  }
  
  else
  {
    return str.toUpperCase();
  }
}
