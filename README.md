# ListViewVirtualization
Run this sample to see how ListView virtualization breaks with unique control conditions


How to break ListView Virtualization in just 3 easy steps:

1. Remove the MinHeight on list view item templates
2. Create item templates via binding
3. Have item templates return inf. height on first measure pass
