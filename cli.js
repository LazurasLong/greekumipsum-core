#!/usr/bin/env node

require('./bin/runtime.js');
require('./bin/functions.js');

const arg = process.argv[2] || '-h';
const num = process.argv[3] || 1;

const ins = new GreekumIpsum();

// Help message
if (arg === '-h' || arg === '--help') {
	console.log(`
Usage
 $ greekum <option> <number>

Options
 -p --paragraph  Generate paragraph
 -w --word       Generate word
 -s --sentence   Generate sentence
 -c --character  Generate character
 -h --help       Display help message

Examples
 $ greekum --paragraph 5
 $ greekum -c 3
 `);
	process.exit(0);
}

// Display an error, if `num` is not a number
if (isNaN(num)) {
	console.log(num, 'is not a number!');
	process.exit(1);
}
// Generate greek paragraphs, words, sentences & characters
if (arg === '-p' || arg === '--paragraph') {
	for (let i = 0; i < num; i++) {
		console.log(ins.NextParagraph());
	}
}

if (arg === '-w' || arg === '--word') {
	process.stdout.write(`${ins.NextWord$1(num)} `);
}

if (arg === '-s' || arg === '--sentence') {
	process.stdout.write(ins.NextSentence$1(true, num));
}

if (arg === '-c' || arg === '--character') {
	for (let i = 0; i < num; i++) {
		process.stdout.write(String.fromCharCode(ins.NextCharacter()));
	}
}
