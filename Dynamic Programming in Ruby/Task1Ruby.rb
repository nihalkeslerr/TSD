#Pieces of cake 

module InstanceModule

    def square
      num = self * self
      puts num
    end
end

module ClassModule
    
    def sample(num)
        if num >= 0 
           array = Array.new(num) { |e| e = rand(1000)}
           puts "#{array}"
        else
           puts "ArgumentError: the number must be positive"
        end
    end
    alias :random :sample
end

class Integer
    include InstanceModule
    extend ClassModule
    def factorial
        if self >= 0 
           num = (1..self).inject(1) { |product, n| product * n }
           puts num
        else 
            puts "Runtime error: cannot count factorial for negative number"
        end
    end
end

5.factorial
-1.factorial
5.square
Integer.sample(3)
Integer.sample(-1)
Integer.random(3)
Integer.random(-1)