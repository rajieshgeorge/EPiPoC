<?xml version="1.0" encoding="utf-8"?>
<module>
    <assemblies>
	    <!-- This adds the Alloy template assembly to the "default module" -->
        <add assembly="$assemblyname$" />
    </assemblies>
    <clientResources>
        <add name="epi-cms.widgets.base" path="Styles/Styles.css" resourceType="Style"/>
    </clientResources>
    <dojo>
        <!-- Add a mapping from alloy to ~/ClientResources/Scripts to the dojo loader configuration -->
        <paths>
            <add name="alloy" path="Scripts" />
        </paths>
    </dojo>
</module>
