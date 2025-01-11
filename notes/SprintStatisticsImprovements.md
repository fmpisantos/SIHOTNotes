# Sprint statistics performance improvement

If a stat is from += 2 days old we consider it as truth.
This means that when loading data from a date that as data saved for the asking sprint and it's "true" we can use the saved information instead of calculating the rest of the information since the start of the sprint.
