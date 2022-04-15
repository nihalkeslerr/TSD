#Let's start thinking
#1.(Min-Max Sum)
def min_max(array)
  
  puts array.sort!().inspect

  puts array
  i=0
  j=1
  max=0
  sum=0
  sum2 = 0
  min=0
  for i in 0..3 do
    sum = sum + array[i]
    min=sum
  end 
  for j in 1..4 do
    sum2 = sum2 + array[j]
    max=sum2
  end
  
 puts "min, #{sum}"
 puts "max, #{sum2}"
  
end
 
min_max([1, 2, 3, 4, 5])  # 10 14
min_max([2, 8, 3, 5, 1])  # 11 18





#2.(Min-Max Sum)
def decimal(decnum)
  binary = []
  nm=decnum.to_i
  stnm=nm.to_s
  
  if nm<0 or
    puts "ArgumentError: this is not a binary number"
  else
    while nm > 0
      binary << nm % 2
      nm = nm / 2
    end
  end
  
  binary.reverse.join
  puts binary
  
end

decimal("101")
decimal("231")  # ArgumentError: this is not a binary number