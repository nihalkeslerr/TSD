
class Clock
  def initialize( hour,minute,second )
    @hour = hour
    @mnt = minute
    @sec = second
  end
  def print
     puts "The current time is = #{@hour}:#{@mnt}:#{@sec}"
  end
  def + (mnt)
    if mnt + @mnt > 59
      @hour = @hour + 1
      @mnt = ((mnt + @mnt) % 60)
    else
      @mnt = mnt +@mnt
    end  
  end
   def + (mnt)
    if mnt + @mnt > 59
      @hour = @hour + 1
      @mnt = ((mnt + @mnt) % 60)
    else
      @mnt = mnt +@mnt
    end  
  end
end

clock = Clock.new(10, 0, 0)
clock.print  # The current time is 10:00:00
clock + 30
clock.print # The current time is 11:10:00