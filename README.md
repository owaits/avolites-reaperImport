# Avolites Titan Reaper Import Widget

## Introduction

This widget designed to work with Avolites WebAPI allows you to import a reaper CSV cue file into the current Titan show. The expected CSV column format is:

Cue Number - the cue number to use within the cue list, if the cue already exists then the legend and timecode will be updated. Otherwise a new cue is created.
Cue Legend - the legend to give the cue
Timecode - the timecode for this cue within the cue list. This should be in standard PC date time format.
Colour - the halo colour to give the cue, this column is optional.

The first line of the CSV file should contain headers.

## Getting Started

We assume that you already have a working Avolites Console that is networked and accessible from this PC or another PC you run this widget on.

Step 1 - visit https://owaits.github.io/avolites-reaperImport
Step 2 - enter the IP address of the console you want to import the reaper tiecodes on and press Connect
Step 3 - if the connection is successful you will be asked to select your repear CSV file to import. Once you have selected the file click Load
Step 4 - you will see a list of all cue lists recorded in your show, select the one you want and select Import

