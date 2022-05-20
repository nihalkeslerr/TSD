package main

import (
	"fmt"
	"regexp"
)

func words(text string) []string {
	words := regexp.MustCompile("\\w+")
	return words.FindAllString(text, -1)
}

func CountingWords(words []string) map[string]int {
	CountingWords := make(map[string]int)
	for _, word := range words {
		CountingWords[word]++
	}
	return CountingWords
}

func print(CountingWords map[string]int) {
	for word, CountingWords := range CountingWords {
		fmt.Printf("%v %v ", word, CountingWords)
	}
}

func main() {
	text := "Go language is a little bit hard language"
	print(CountingWords(words(text)))
}