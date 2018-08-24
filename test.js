import test from 'ava';
import execa from 'execa';

test('Test general output', async t => {
	const ret = await execa.shell('node ./cli.js');
	t.regex(ret.stdout, /Usage/);
});

test('Test --help output', async t => {
	const ret = await execa.shell('node ./cli.js --help');
	t.regex(ret.stdout, /Examples/);
});

test('Test --paragraph output', async t => {
	const ret = await execa.shell('node ./cli.js --paragraph');
	t.regex(ret.stdout, /α/);
});

test('Test --sentence output', async t => {
	const {stdout} = await execa.shell('node ./cli.js --sentence');
	t.true(stdout.length < 300);
});

test('Test --word output', async t => {
	const {stdout} = await execa.shell('node ./cli.js --word');
	t.true(stdout.length < 75);
});

test('Test --character output', async t => {
	const {stdout} = await execa.shell('node ./cli.js --character');
	t.true(stdout.length === 1);
});

test('Test --paragraph output with number', async t => {
	const ret = await execa.shell('node ./cli.js --paragraph 2');
	t.regex(ret.stdout, /α/);
});

test('Test --sentence output with number', async t => {
	const {stdout} = await execa.shell('node ./cli.js --sentence 2');
	t.true(stdout.length < 250);
});

test('Test --word output with number', async t => {
	const {stdout} = await execa.shell('node ./cli.js --word 2');
	t.true(stdout.length < 100);
});

test('Test --character output with number', async t => {
	const {stdout} = await execa.shell('node ./cli.js --character 2');
	t.true(stdout.length === 2);
});

test('Test not a number output', async t => {
	const ret = await t.throws(execa.shell('node ./cli.js --word foo'));
	t.is(ret.code, 1);
	t.regex(ret.stdout, /is not a number!/);
});

test('Test --word output with the number 500', async t => {
	const {stdout} = await execa.shell('node ./cli.js --word 500');
	t.true(stdout.length > 0);
});
