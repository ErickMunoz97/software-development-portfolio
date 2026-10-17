# Publishing checklist

1. Review every source file and README to confirm it represents your own work and that any course policy allows publication. If not, keep the repository **private**.
2. Review all placeholder images and documentation. Supply only images you created or are licensed to distribute.
3. Do **not** copy your original `.git` folder, compiled programs, passwords, personal data, old database dumps, or `.rar` archives.
4. Run the Java project smoke tests on your computer; check the Xamarin and WPF builds on their supported platforms if you plan to claim they run.
5. Create a new empty GitHub repository called `software-development-portfolio`, then upload **the contents of this folder**, not the original big archive or the ZIP itself.
6. Only make the repository public after checking the source and school policies. Link `https://github.com/ErickMunoz97/software-development-portfolio` in the resume after confirming it actually exists and is accessible.

## Recommended Git commands

From inside the unzipped portfolio folder (with Git installed and your identity configured):

```bash
git init
git add .
git commit -m "Add curated student programming portfolio"
git branch -M main
git remote add origin https://github.com/ErickMunoz97/software-development-portfolio.git
git push -u origin main
```

Create the empty GitHub repository first. If it already exists or has a README, adjust the commands accordingly. Authentication may be required.
