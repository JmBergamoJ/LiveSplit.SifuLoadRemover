# LiveSplit.SifuLoadRemover
LiveSplit component to automatically detect and remove load times from [Sifu](https://www.epicgames.com/store/en-US/p/sifu).

This is adapted from [Thomasneff's LiveSplit.CrashNSTLoadRemoval](https://github.com/thomasneff/LiveSplit.CrashNSTLoadRemoval "Thomasneff's LiveSplit.CrashNSTLoadRemoval")
and from [Grimelios's LiveSplit.Crash](https://github.com/Grimelios/LiveSplit.Crash "Grimelios's LiveSplit.Crash") Auto-Spliiter Component

This component uses OCR to automatically detect loading screens and pause the Game Timer.

This was possible thanks to [Charles Weld's Tesseract](https://github.com/charlesw/tesseract)

# How does it work?
The method works by using [Optical Character Recognition](https://en.wikipedia.org/wiki/Optical_character_recognition) to check if the game is considered to be in a Loading State.

The tool is designed to be as easy to use as possible, in most cases requiring zero configuration whatsoever (just activate and go).

# Known Issues

If you want to use the AutoSplitter functionality, **all your Splits need to have different names!**. If you have Splits that share the same name, the AutoSplitter is not able to differentiate between them.
Currently only works with the English Version of the game.

## Installation instructions for LiveSplit

- Download LiveSplit.SifuLoadRemover [HERE](https://github.com/JmBergamoJ/LiveSplit.SifuLoadRemover/raw/master/Download/LiveSplit.SifuLoadRemover.zip)
- Extract the contents to your LiveSplit/Components folder (you should see lots of other DLL's in there)
- Open LiveSplit, then right-click and select Edit Layout
- Add the autosplitter (under the Control category)
- If desired, click Layout Settings (or double-click the newly-added component) to configure the autosplitter

## Known deficiencies

- The timer doesn't start automatically and doesn't end automatically. This is due to the fact that different categories have different end criteria. For the time being, make sure to split manually during the start and end of your run.
- Third party dependencies not bundled into the Component, I.E [Tesseract](https://github.com/charlesw/tesseract)

# Official Sifu Unofficial Server

Make sure to check out the [Official Sifu Unofficial Server!](https://discord.gg/9t9UvRfm)
