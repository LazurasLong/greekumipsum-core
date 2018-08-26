# Greekum Ipsum 📝

> Generate random greek paragraphs, sentences & more.

[![npm version](https://badge.fury.io/js/greekumipsum-cli.svg)](https://badge.fury.io/js/greekumipsum-cli) 
[![XO code style](https://img.shields.io/badge/code_style-XO-5ed9c7.svg)](https://github.com/xojs/xo) 
[![npm license](https://img.shields.io/npm/l/greekumipsum-cli.svg)](https://opensource.org/licenses/MIT)


[![NPM](https://nodei.co/npm/greekumipsum-cli.png?downloads=true&downloadRank=true&stars=true)](https://nodei.co/npm/greekumipsum-cli/)

![Animated SVG](https://cdn.rawgit.com/Greekum/greekumipsum/6d95621c/animated.svg)

| CLI (Node.js)     | Original (Bridge) | Original (C#)     | Tests (Node.js)   |
|-------------------|-------------------|-------------------|-------------------|
| [![Build 1](https://travis-matrix-badges.herokuapp.com/repos/Greekum/greekumipsum/branches/master/1)](https://travis-ci.org/Greekum/greekumipsum) | [![Build 2](https://travis-matrix-badges.herokuapp.com/repos/Greekum/greekumipsum/branches/master/2)](https://travis-ci.org/Greekum/greekumipsum) | [![Build 3](https://travis-matrix-badges.herokuapp.com/repos/Greekum/greekumipsum/branches/master/3)](https://travis-ci.org/Greekum/greekumipsum) | [![Build 4](https://travis-matrix-badges.herokuapp.com/repos/Greekum/greekumipsum/branches/master/4)](https://travis-ci.org/Greekum/greekumipsum) |

# What is Greekum Ipsum?
Original description:

> Greekum Ipsum is variation of Lorem Ipsum. It was made by [Krzysztof Szewczyk](https://github.com/KrzysztofSzewczyk), serving same purpose as Lorem Ipsum, with another feature - creating generators of this, or even trying it out in applications or websites, can test system's capability to render unicode characters.

# Install
```bash
npm install --global greekumipsum-cli
```

You can also use the [online generator](https://krzysztofszewczyk.github.io/MiscStuff/greekum/)!

# Usage

```bash
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
```
## Note
This CLI app is just a simple wrapper around the original Greekum Ipsum script, made by my friend [Krzysztof Szewczyk](https://github.com/KrzysztofSzewczyk). 
All credit should go to him 😄

## Maintainers

[![Antoni Kepinski](https://github.com/xxczaki.png?size=100)](https://kepinski.me) | [![Krzysztof Szewczyk](https://github.com/KrzysztofSzewczyk.png?size=100)](https://github.com/KrzysztofSzewczyk)
---|---
[Antoni Kepinski](https://kepinski.me) | [Krzysztof Szewczyk](https://github.com/KrzysztofSzewczyk)

## TODO lists

C# things need to be made first.

### C# TODO list:
 * [X] Allow application to start clean
 * [ ] Add Learn(char) and Learn(string) methods to GreekumIpsum
 * [X] Move GreekumIpsum classes to separate package, avoiding global namespace pollution
 * [X] Add some form of config files <-- It's JavaScript's problem
 * [ ] Add more friendly API
 * [ ] [1]: Compile Greekum-Harvester to JavaScript and open-source it (it's tool to grab statistics from eg. text file)
 * [ ] Allow to emit markdown
 * [X] Integrate for loop
 * [X] Split runtime and code

### JavaScript TODO list:
 * [ ] Add configuration file support:
   * [ ] Create configuration files starting clean or predefined
   * [ ] Save, load configuration
   * [ ] Add some more predefined configurations
   * [ ] Look [1]
  * [X] Optimize CLI (it's wasting some memory now)
  * [ ] Add learning frontend
  * [ ] Add GreekumHarvester CLI frontend
  * [ ] Very basic markdown highlighting (?, unsure): `**, ****, # `
  * [ ] Add commandline option to uppercase sentence.
  * [X] If `num` is not passed, assume 1.

### General TODO list:
 * [X] Move this to README
 * [ ] Get rid of heavy Bridge runtime
