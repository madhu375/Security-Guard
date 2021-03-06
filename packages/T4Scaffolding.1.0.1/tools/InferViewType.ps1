param($rootPath, $toolsPath, $package, $project)

### Copied from MvcScaffolding
function CountSolutionFilesByExtension($extension) {
    Write-Host (%{ [System.IO.Directory]::EnumerateFiles($_, "*." + $extension, [System.IO.SearchOption]::AllDirectories) })
	$files = (Get-Project).DTE.Solution `
		| ?{ $_.FileName } `
		| %{ [System.IO.Path]::GetDirectoryName($_.FileName) } `
		| %{ [System.IO.Directory]::EnumerateFiles($_, "*." + $extension, [System.IO.SearchOption]::AllDirectories) }
	($files | Measure-Object).Count
}

function InferPreferredViewEngine() {
	# Assume you want Razor except if you already have some ASPX views and no Razor ones
    Write-Host Count (CountSolutionFilesByExtension aspx)
	if ((CountSolutionFilesByExtension aspx) -eq 0) { return "razor" }
	if (((CountSolutionFilesByExtension cshtml) -gt 0) -or ((CountSolutionFilesByExtension vbhtml) -gt 0)) { return "razor" }
	return "aspx"
}

# Infer which view engine you're using based on the files in your project
### End copied

$ViewType = if ([string](InferPreferredViewEngine) -eq 'aspx') { "Aspx" } else { "Razor" }

Write-Host This is your view type - $ViewType