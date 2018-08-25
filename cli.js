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

// Handle unhandled rejections easily
process.on('unhandledRejection', err => {
	console.error('Something went wrong :(\n', err);
});
// Display an error, if `num` is not a number
if (isNaN(num)) {
	console.log(num, 'is not a number!');
	process.exit(1);
}
// Generate greek paragraphs, words, sentences & characters
if (arg === '-p' || arg === '--paragraph') {
	(async () => {
		const result = await ins.NextParagraph$1(num);
		process.stdout.write(result);
	})();
}

if (arg === '-w' || arg === '--word') {
	(async () => {
		const result = await ins.NextWord$1(num);
		process.stdout.write(result);
	})();
}

if (arg === '-s' || arg === '--sentence') {
	(async () => {
		const result = await ins.NextSentence$1(true, num);
		process.stdout.write(result);
	})();
}

if (arg === '-c' || arg === '--character') {
	(async () => {
		const result = await ins.NextCharacter$1(num);
		process.stdout.write(result);
	})();
}
