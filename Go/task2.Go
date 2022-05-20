package main

import "fmt"

func fibonacci() func() int {
	num := 0
	x := 0
	y := 1
	z := x + y
	return func() int {
		var ans int
		switch {
		case num == 0:
			num++
			ans = 0
		case num == 1:
			num++
			ans = 1
		default:
			ans = z
			x = y
			y = z
			z = x + y
		}
		return ans
	}
}

func main() {
	f := fibonacci()
	for i := 0; i < 10; i++ {
		fmt.Println(f())
	}
}
