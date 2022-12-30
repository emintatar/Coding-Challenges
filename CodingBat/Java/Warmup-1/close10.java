// Given 2 int values, return whichever value is nearest to the value 10, or return 0 in the event of a tie. Note that Math.abs(n) returns the absolute value of a number.


// close10(8, 13) → 8
// close10(13, 8) → 8
// close10(13, 7) → 0

public int close10(int a, int b) 
{
  int distance_a = Math.abs(a - 10);
  int distance_b = Math.abs(b - 10);
  
  if (distance_a == distance_b)
  {
    return 0;
  }
  
  else
  {
    if (distance_a < distance_b)
    {
      return a;
    }
    
    else
    {
      return b;
    }
  }
}
