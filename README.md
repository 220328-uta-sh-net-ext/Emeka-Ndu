# Static Code Analysis

Static Code Analysis is usually performed as part of a Code Review (also known as white-box testing) and is carried out at the Implementation phase of a Security Development Lifecycle (SDL) to highlight possible vulnerabilities within ‘static’ (non-running) source code by using techniques such as Taint Analysis and Data Flow Analysis.

## Techniques
There are various techniques to analyze static source code for potential vulnerabilities that maybe combined into one solution. These techniques are often derived from compiler technologies.

### Data Flow Analysis
Data flow analysis is used to collect run-time (dynamic) information about data in software while it is in a static state.

There are three common terms used in data flow analysis, **basic block (the code), Control Flow Analysis (the flow of data) and Control Flow Path (the path the data takes)**

Other concepts include....

**Taint Analysis:** They are attempts to identify variables that have been ‘tainted’ with user controllable input and traces them to possible vulnerable functions also known as a ‘sink’.

**Lexical Analysis:** converts source code syntax into ‘tokens’ of information in an attempt to abstract the source code and make it easier to manipulate.

## Strengths and Weaknesses

**Strengths:** 

  1. Scales well (Can be run on lots of software, and can be repeatedly (like in nightly builds))

  2.For things that such tools can automatically find with high confidence, such as buffer overflows, SQL Injection Flaws, etc, they are great.

**Weaknesses**

Many types of security vulnerabilities are very difficult to find automatically, such as authentication problems, access control issues, insecure use of cryptography, etc.

Other weaknesses include high numbers of false positives.

Frequently can’t find configuration issues, since they are not represented in the code.

Difficult to ‘prove’ that an identified security issue is an actual vulnerability.


Source: https://owasp.org/www-community/controls/Static_Code_Analysis
