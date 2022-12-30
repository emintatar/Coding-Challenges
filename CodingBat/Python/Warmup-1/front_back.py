# Given a string, return a new string where the first and last chars have been exchanged.


# front_back('code') → 'eodc'
# front_back('a') → 'a'
# front_back('ab') → 'ba

def front_back(str):
  if (len(str) > 1):
    newFirst = str[-1]
    newLast = str[0]
    newString = newFirst + str[1:len(str)-1] + newLast 
    return newString
  else:
    return str
