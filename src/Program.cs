using System;
using System.IO;

public class ThemeGenerator
{
	public static void Main()
	{
		// Console.WriteLine(Holder.Json());
		Console.WriteLine(Holder.Xml());

		// Output to File (optional)
		// File.WriteAllText("Moonlight.json", jsonOutput);
	}
}

public static class Holder
{
	// ---------------------------------------------------------
	// 1. Color Variables
	// Define hex codes here for easier maintenance.
	// ---------------------------------------------------------
	static string cBase     = "#2a2840";
	static string cSurface  = "#2a2840";
	static string cOverlay  = "#393552";
	static string cInactive = "#59546d";
	static string cSubtle   = "#9c9cbf";
	static string cText     = "#c0c0ff";

	static string cRed      = "#fa593f";
	static string cYellow   = "#fcb986";
	static string cOrange   = "#ff744d";
	static string cMagenta  = "#f23cb8";
	static string cGreen    = "#c8e899";
	static string cLavender = "#f096ea";
	static string cBlue     = "#848bf4";
	static string cCyan     = "#80b5f7";
	static string cPurple   = "#c188ef";

	// Alpha / Transparent variants
	static string cRedDark      = "#fa593f99";
	static string cYellowDark   = "#fcb98699";
	static string cOrangeDark   = "#ff744d99";
	static string cMagentaDark  = "#f23cb899";
	static string cGreenDark    = "#c8e89999";
	static string cLavenderDark = "#f096ea99";
	static string cBlueDark     = "#848bf499";
	static string cCyanDark     = "#80b5f799";
	static string cPurpleDark   = "#c188ef99";

	// UI Highlights
	static string cHighlight         = "#393552";
	static string cHighlightInactive = "#201e30";
	static string cHighlightOverlay  = "#201e30";

	public static string Json()
	{
		// ---------------------------------------------------------
		// 2. JSON Construction
		// Uses $@"..." syntax.
		// "" = " (escaped quote)
		// {{ = { (escaped brace)
		// ---------------------------------------------------------
		string jsonOutput = $@"{{
  ""name"": ""Moonlight"",
  ""dark"": true,
  ""author"": ""Rikai"",
  ""editorScheme"": ""/Moonlight.xml"",
  ""colors"": {{
    ""base"": ""{cBase}"",
    ""surface"": ""{cSurface}"",
    ""overlay"": ""{cOverlay}"",
    ""inactive"": ""{cInactive}"",
    ""subtle"": ""{cSubtle}"",
    ""text"": ""{cText}"",
    ""red"": ""{cRed}"",
    ""yellow"": ""{cYellow}"",
    ""orange"": ""{cOrange}"",
    ""magenta"": ""{cMagenta}"",
    ""green"": ""{cGreen}"",
    ""lavender"": ""{cLavender}"",
    ""blue"": ""{cBlue}"",
    ""cyan"": ""{cCyan}"",
    ""purple"": ""{cPurple}"",
    ""RedDark"": ""{cRedDark}"",
    ""yellowDark"": ""{cYellowDark}"",
    ""orangeDark"": ""{cOrangeDark}"",
    ""magentaDark"": ""{cMagentaDark}"",
    ""greenDark"": ""{cGreenDark}"",
    ""lavender1a"": ""{cLavenderDark}"",
    ""blue1a"": ""{cBlueDark}"",
    ""cyan1a"": ""{cCyanDark}"",
    ""purple1a"": ""{cPurpleDark}"",
    ""highlight"": ""{cHighlight}"",
    ""highlightInactive"": ""{cHighlightInactive}"",
    ""highlightOverlay"": ""{cHighlightOverlay}""
  }},
  ""ui"": {{
    ""*"": {{
      ""background"": ""base"",
      ""foreground"": ""text"",
      ""infoForeground"": ""inactive"",
      ""successForeground"": ""inactive"",
      ""selectionBackground"": ""highlight"",
      ""selectionForeground"": ""text"",
      ""selectionInactiveBackground"": ""highlightInactive"",
      ""selectionBackgroundInactive"": ""highlightInactive"",
      ""disabledBackground"": ""surface"",
      ""inactiveBackground"": ""surface"",
      ""disabledForeground"": ""text"",
      ""disabledText"": ""text"",
      ""inactiveForeground"": ""text"",
      ""acceleratorForeground"": ""highlight"",
      ""acceleratorSelectionForeground"": ""highlight"",
      ""errorForeground"": ""red"",
      ""borderColor"": ""overlay"",
      ""disabledBorderColor"": ""highlightInactive"",
      ""focusColor"": ""highlightOverlay"",
      ""focusedBorderColor"": ""highlight"",
      ""hoverBorderColor"": ""highlight"",
      ""pressedBorderColor"": ""highlight"",
      ""separatorColor"": ""highlight"",
      ""lineSeparatorColor"": ""highlight"",
      ""Label"": {{
        ""background"": ""surface"",
        ""foreground"": ""highlight"",
        ""selectedForeground"": ""highlight""
      }}
    }},
    ""ActionButton"": {{
      ""hoverBackground"": ""highlight"",
      ""pressedBackground"": ""highlight""
    }},
    ""Button"": {{
      ""startBackground"": ""overlay"",
      ""endBackground"": ""overlay"",
      ""startBorderColor"": ""overlay"",
      ""endBorderColor"": ""overlay"",
      ""foreground"": ""text"",
      ""default"": {{
        ""foreground"": ""text"",
        ""startBackground"": ""highlight"",
        ""endBackground"": ""highlight"",
        ""startBorderColor"": ""highlight"",
        ""endBorderColor"": ""highlight"",
        ""focusedBorderColor"": ""highlight""
      }}
    }},
    ""SearchEverywhere"": {{
      ""Tab"": {{
        ""selectedBackground"": ""highlightOverlay"",
        ""selectedForeground"": ""text""
      }}
    }},
    ""Borders"": {{
      ""color"": ""surface"",
      ""ContrastBorderColor"": ""surface""
    }},
    ""Editor"": {{
      ""background"": ""base"",
      ""foreground"": ""text"",
      ""shortcutForeground"": ""highlight""
    }},
    ""EditorTabs"": {{
      ""background"": ""base"",
      ""hoverBackground"": ""highlightOverlay"",
      ""underlinedTabBackground"": ""highlightOverlay"",
      ""underlineColor"": ""pine"",
      ""underlineHeight"": 4,
      ""inactiveColoredFileBackground"": ""inactive""
    }},
    ""Lesson"": {{
      ""shortcutBackground"": ""surface"",
      ""stepNumberForeground"": ""text"",
      ""Tooltip"": {{
        ""background"": ""overlay"",
        ""spanBackground"": ""surface"",
        ""foreground"": ""text"",
        ""stepNumberForeground"": ""text""
      }}
    }},
    ""GutterTooltip"": {{
      ""infoForeground"": ""highlight""
    }},
    ""ToolTip"": {{
      ""Actions"": {{
        ""infoForeground"": ""lavender""
      }},
      ""background"": ""overlay"",
      ""shortcutForeground"": ""lavender"",
      ""infoForeground"": ""lavender""
    }},
    ""SearchMatch"": {{
      ""startBackground"": ""highlight"",
      ""endBackground"": ""highlight""
    }},
    ""GotItTooltip"": {{
      ""shortcutForeground"": ""blue""
    }},
    ""FileColor"": {{
      ""Red"": ""RedDark"",
      ""Yellow"": ""yellowDark"",
      ""Orange"": ""orangeDark"",
      ""Magenta"": ""magentaDark"",
      ""Green"": ""greenDark"",
      ""Lavender"": ""lavender1a"",
      ""Blue"": ""blue1a"",
      ""Cyan"": ""cyan1a"",
      ""Purple"": ""purple1a""
    }},
    ""Component"": {{
      ""infoForeground"": ""blue""
    }},
    ""Panel"": {{
      ""mouseShortcutBackground"": ""blue""
    }},
    ""/*/ 1. Force generic Lists to be light text /*"": """",
    ""List"": {{
      ""foreground"": ""text"",
      ""background"": ""base"",
      ""selectionForeground"": ""text"",
      ""selectionBackground"": ""highlight""
    }},
    ""/*/ 2. SPECIFICALLY target the Search Everywhere popup /*"": """",
    ""SearchEverywhere.List"": {{
      ""foreground"": ""text"",
      ""background"": ""base"",
      ""selectionForeground"": ""text"",
      ""selectionBackground"": ""highlight""
    }},
    ""SearchEverywhere.SearchField"": {{
      ""background"": ""base"",
      ""foreground"": ""text""
    }},
    ""/*/ 3. Fix the 'Actions' tab inside Search Everywhere /*"": """",
    ""ActionList"": {{
      ""hoverBackground"": ""highlight"",
      ""selectionBackground"": ""highlight"",
      ""selectionForeground"": ""text""
    }},
    ""/*/ 4. Fix the standard Tree (File Explorer) just in case /*"": """",
    ""Tree"": {{
      ""selectionForeground"": ""text"",
      ""selectionBackground"": ""highlight""
    }}
  }}
}}";

		return jsonOutput;
	}

	public static string Xml()
	{
		// ==========================================
		// 1. Color Palette Variables
		// ==========================================

		// Backgrounds & Base UI
		string cBgBase      = "2A2840";
		string cBgCaret     = "393552";
		string cBgSelection = "504A81";
		string cBgHint      = "2c343e";

		// UI Borders & Decorators
		string cGuide       = "4B5263";
		string cScrollAlpha = "4B5263A6"; // Includes Alpha channel
		string cLineNums    = "59546D";

		// Text & Foreground
		string cFgDefault = "C4C1EC"; // Light Lavender
		string cFgMuted   = "9293A5"; // Grayish Purple
		string cFgComment = "9c9cbf"; // Muted Blue-Gray
		string cFgIgnored = "C0C0FF";

		// Syntax Colors
		string cRed          = "f7504b";
		string cRedLight     = "f47c7c";
		string cOrange       = "fcb986";
		string cOrangeWarn   = "f7ab4c";
		string cOrangeBright = "ff744d";
		string cYellow       = "f0d896";
		string cGreen        = "acf0a3";
		string cGreenDark    = "6a8759";
		string cGreenLime    = "c8e899";
		string cGreenBright  = "ddffa7";
		string cCyan         = "7cb2f4";
		string cBlue         = "8a92fc";
		string cPurple       = "be7df5";
		string cMagenta      = "f096ea";
		string cHotPink      = "f74fc1";
		string cGrayEffect   = "c3c3c3";

		// ==========================================
		// 2. XML Generation
		// Uses $@ for multi-line + interpolation.
		// "" = escaped quote
		// {{ }} = escaped braces
		// ==========================================

		string xmlOutput = $@"<scheme name=""Moonlight"" version=""142"" parent_scheme=""Darcula"">
    <metaInfo>
        <property name=""ide"">Rider</property>
        <property name=""ideVersion"">2025.3.1.0.0</property>
    </metaInfo>
    <colors>
        <option name=""CARET_ROW_COLOR"" value=""{cBgCaret}""/>
        <option name=""DOCUMENTATION_COLOR"" value=""""/>
        <option name=""DOC_COMMENT_LINK"" value=""{cMagenta}""/>
        <option name=""EDITOR_GUTTER_BACKGROUND"" value=""""/>
        <option name=""FILESTATUS_ADDED"" value=""""/>
        <option name=""FILESTATUS_COPIED"" value=""""/>
        <option name=""FILESTATUS_DELETED"" value=""""/>
        <option name=""FILESTATUS_HIJACKED"" value=""{cFgIgnored}""/>
        <option name=""FILESTATUS_IDEA_FILESTATUS_DELETED_FROM_FILE_SYSTEM"" value=""""/>
        <option name=""FILESTATUS_IDEA_FILESTATUS_IGNORED"" value=""""/>
        <option name=""FILESTATUS_IDEA_FILESTATUS_MERGED_WITH_BOTH_CONFLICTS"" value=""""/>
        <option name=""FILESTATUS_IDEA_FILESTATUS_MERGED_WITH_CONFLICTS"" value=""""/>
        <option name=""FILESTATUS_IDEA_FILESTATUS_MERGED_WITH_PROPERTY_CONFLICTS"" value=""""/>
        <option name=""FILESTATUS_MERGED"" value=""""/>
        <option name=""FILESTATUS_MODIFIED"" value=""""/>
        <option name=""FILESTATUS_NOT_CHANGED_IMMEDIATE"" value=""""/>
        <option name=""FILESTATUS_NOT_CHANGED_RECURSIVE"" value=""""/>
        <option name=""FILESTATUS_RENAMED"" value=""""/>
        <option name=""FILESTATUS_UNKNOWN"" value=""""/>
        <option name=""FILESTATUS_addedOutside"" value=""""/>
        <option name=""FILESTATUS_changelistConflict"" value=""""/>
        <option name=""FILESTATUS_modifiedOutside"" value=""""/>
        <option name=""FOLDED_TEXT_BORDER_COLOR"" value=""""/>
        <option name=""INDENT_GUIDE"" value=""{cGuide}""/>
        <option name=""INLINE_REFACTORING_SETTINGS_DEFAULT"" value=""{cFgMuted}""/>
        <option name=""INLINE_REFACTORING_SETTINGS_FOCUSED"" value=""""/>
        <option name=""INLINE_REFACTORING_SETTINGS_HOVERED"" value=""""/>
        <option name=""LINE_NUMBERS_COLOR"" value=""{cLineNums}""/>
        <option name=""LINE_NUMBER_ON_CARET_ROW_COLOR"" value=""{cFgDefault}""/>
        <option name=""MATCHED_BRACES_INDENT_GUIDE_COLOR"" value=""{cGuide}""/>
        <option name=""METHOD_SEPARATORS_COLOR"" value=""{cGuide}""/>
        <option name=""NOTIFICATION_BACKGROUND"" value=""{cGuide}""/>
        <option name=""PREVIEW_BACKGROUND"" value=""{cBgBase}""/>
        <option name=""RIGHT_MARGIN_COLOR"" value=""{cGuide}""/>
        <option name=""SELECTED_INDENT_GUIDE"" value=""{cGuide}""/>
        <option name=""SELECTED_TEARLINE_COLOR"" value=""{cGuide}""/>
        <option name=""SELECTION_BACKGROUND"" value=""{cBgSelection}""/>
        <option name=""ScrollBar.hoverThumbColor"" value=""{cScrollAlpha}""/>
        <option name=""ScrollBar.thumbColor"" value=""{cScrollAlpha}""/>
        <option name=""TEARLINE_COLOR"" value=""{cGuide}""/>
        <option name=""VISUAL_INDENT_GUIDE"" value=""{cGuide}""/>
        <option name=""WHITESPACES"" value=""{cFgDefault}""/>
    </colors>
    <attributes>
        <option name=""BAD_CHARACTER"">
            <value>
                <option name=""FOREGROUND"" value=""{cRed}""/>
                <option name=""ERROR_STRIPE_COLOR"" value=""{cRed}""/>
                <option name=""EFFECT_TYPE"" value=""2""/>
            </value>
        </option>
        <option name=""CODE_VISION_DEFAULT"">
            <value>
                <option name=""FOREGROUND"" value=""{cFgMuted}""/>
            </value>
        </option>
        <option name=""CODE_VISION_HOVERED"">
            <value>
                <option name=""FOREGROUND"" value=""{cBlue}""/>
            </value>
        </option>
        <option name=""CTRL_CLICKABLE"">
            <value>
                <option name=""FOREGROUND"" value=""{cPurple}""/>
                <option name=""EFFECT_COLOR"" value=""{cPurple}""/>
                <option name=""EFFECT_TYPE"" value=""1""/>
            </value>
        </option>
        <option name=""DEFAULT_ATTRIBUTE"">
            <value>
                <option name=""FOREGROUND"" value=""{cFgDefault}""/>
            </value>
        </option>
        <option name=""DEFAULT_BLOCK_COMMENT"">
            <value>
                <option name=""FOREGROUND"" value=""{cFgComment}""/>
                <option name=""FONT_TYPE"" value=""2""/>
            </value>
        </option>
        <option name=""DEFAULT_BRACES"">
            <value>
                <option name=""FOREGROUND"" value=""{cBlue}""/>
            </value>
        </option>
        <option name=""DEFAULT_BRACKETS"">
            <value>
                <option name=""FOREGROUND"" value=""{cBlue}""/>
            </value>
        </option>
        <option name=""DEFAULT_CLASS_NAME"">
            <value>
                <option name=""FOREGROUND"" value=""{cHotPink}""/>
            </value>
        </option>
        <option name=""DEFAULT_CLASS_REFERENCE"">
            <value>
                <option name=""FOREGROUND"" value=""{cGreen}""/>
            </value>
        </option>
        <option name=""DEFAULT_COMMA"">
            <value>
                <option name=""FOREGROUND"" value=""{cHotPink}""/>
            </value>
        </option>
        <option name=""DEFAULT_CONSTANT"">
            <value>
                <option name=""FOREGROUND"" value=""{cMagenta}""/>
            </value>
        </option>
        <option name=""DEFAULT_DOC_COMMENT"">
            <value>
                <option name=""FOREGROUND"" value=""{cFgComment}""/>
                <option name=""FONT_TYPE"" value=""2""/>
            </value>
        </option>
        <option name=""DEFAULT_DOC_COMMENT_TAG"">
            <value>
                <option name=""FOREGROUND"" value=""{cGreen}""/>
                <option name=""EFFECT_TYPE"" value=""1""/>
            </value>
        </option>
        <option name=""DEFAULT_DOC_COMMENT_TAG_VALUE"">
            <value>
                <option name=""FOREGROUND"" value=""{cFgDefault}""/>
            </value>
        </option>
        <option name=""DEFAULT_DOC_MARKUP"">
            <value>
                <option name=""FOREGROUND"" value=""{cMagenta}""/>
            </value>
        </option>
        <option name=""DEFAULT_DOT"">
            <value>
                <option name=""FOREGROUND"" value=""{cBlue}""/>
            </value>
        </option>
        <option name=""DEFAULT_ENTITY"">
            <value>
                <option name=""FOREGROUND"" value=""{cFgDefault}""/>
            </value>
        </option>
        <option name=""DEFAULT_FUNCTION_CALL"">
            <value>
                <option name=""FOREGROUND"" value=""{cPurple}""/>
            </value>
        </option>
        <option name=""DEFAULT_FUNCTION_DECLARATION"">
            <value>
                <option name=""FOREGROUND"" value=""{cPurple}""/>
            </value>
        </option>
        <option name=""DEFAULT_GLOBAL_VARIABLE"">
            <value>
                <option name=""FOREGROUND"" value=""{cFgDefault}""/>
            </value>
        </option>
        <option name=""DEFAULT_HIGHLIGHTED_REFERENCE"">
            <value>
                <option name=""FOREGROUND"" value=""{cGreenDark}""/>
            </value>
        </option>
        <option name=""DEFAULT_IDENTIFIER"">
            <value>
                <option name=""FOREGROUND"" value=""{cFgMuted}""/>
            </value>
        </option>
        <option name=""DEFAULT_INSTANCE_FIELD"">
            <value>
                <option name=""FOREGROUND"" value=""{cBlue}""/>
            </value>
        </option>
        <option name=""DEFAULT_INTERFACE_NAME"">
            <value>
                <option name=""FOREGROUND"" value=""{cHotPink}""/>
            </value>
        </option>
        <option name=""DEFAULT_INVALID_STRING_ESCAPE"">
            <value>
                <option name=""FOREGROUND"" value=""{cRed}""/>
                <option name=""ERROR_STRIPE_COLOR"" value=""{cRed}""/>
                <option name=""EFFECT_TYPE"" value=""2""/>
            </value>
        </option>
        <option name=""DEFAULT_KEYWORD"">
            <value>
                <option name=""FOREGROUND"" value=""{cMagenta}""/>
            </value>
        </option>
        <option name=""DEFAULT_LABEL"">
            <value>
                <option name=""FOREGROUND"" value=""{cFgDefault}""/>
            </value>
        </option>
        <option name=""DEFAULT_LINE_COMMENT"">
            <value>
                <option name=""FOREGROUND"" value=""{cFgComment}""/>
                <option name=""FONT_TYPE"" value=""2""/>
            </value>
        </option>
        <option name=""DEFAULT_LOCAL_VARIABLE"">
            <value>
                <option name=""FOREGROUND"" value=""{cFgDefault}""/>
            </value>
        </option>
        <option name=""DEFAULT_METADATA"">
            <value>
                <option name=""FOREGROUND"" value=""{cYellow}""/>
            </value>
        </option>
        <option name=""DEFAULT_NUMBER"">
            <value>
                <option name=""FOREGROUND"" value=""{cOrange}""/>
            </value>
        </option>
        <option name=""DEFAULT_OPERATION_SIGN"">
            <value>
                <option name=""FOREGROUND"" value=""{cBlue}""/>
            </value>
        </option>
        <option name=""DEFAULT_PARAMETER"">
            <value>
                <option name=""FOREGROUND"" value=""{cFgDefault}""/>
            </value>
        </option>
        <option name=""DEFAULT_PARENTHS"">
            <value>
                <option name=""FOREGROUND"" value=""{cBlue}""/>
            </value>
        </option>
        <option name=""DEFAULT_PREDEFINED_SYMBOL"">
            <value>
                <option name=""FOREGROUND"" value=""{cFgMuted}""/>
            </value>
        </option>
        <option name=""DEFAULT_REASSIGNED_LOCAL_VARIABLE"">
            <value>
                <option name=""FOREGROUND"" value=""{cFgDefault}""/>
                <option name=""EFFECT_COLOR"" value=""{cFgDefault}""/>
                <option name=""EFFECT_TYPE"" value=""1""/>
            </value>
        </option>
        <option name=""DEFAULT_REASSIGNED_PARAMETER"">
            <value>
                <option name=""FOREGROUND"" value=""{cFgDefault}""/>
                <option name=""EFFECT_COLOR"" value=""{cFgDefault}""/>
                <option name=""EFFECT_TYPE"" value=""1""/>
            </value>
        </option>
        <option name=""DEFAULT_SEMICOLON"">
            <value>
                <option name=""FOREGROUND"" value=""{cBlue}""/>
            </value>
        </option>
        <option name=""DEFAULT_STATIC_FIELD"">
            <value>
                <option name=""FOREGROUND"" value=""{cBlue}""/>
            </value>
        </option>
        <option name=""DEFAULT_STATIC_METHOD"">
            <value>
                <option name=""FOREGROUND"" value=""{cPurple}""/>
            </value>
        </option>
        <option name=""DEFAULT_STRING"">
            <value>
                <option name=""FOREGROUND"" value=""{cCyan}""/>
            </value>
        </option>
        <option name=""DEFAULT_TAG"">
            <value>
                <option name=""FOREGROUND"" value=""{cFgDefault}""/>
                <option name=""EFFECT_TYPE"" value=""5""/>
            </value>
        </option>
        <option name=""DEFAULT_TEMPLATE_LANGUAGE_COLOR"" baseAttributes=""TEXT""/>
        <option name=""DEFAULT_VALID_STRING_ESCAPE"">
            <value>
                <option name=""FOREGROUND"" value=""{cMagenta}""/>
            </value>
        </option>
        <option name=""DELETED_TEXT_ATTRIBUTES"">
            <value>
                <option name=""BACKGROUND"" value=""{cBgBase}""/>
                <option name=""EFFECT_COLOR"" value=""{cGrayEffect}""/>
                <option name=""EFFECT_TYPE"" value=""3""/>
            </value>
        </option>
        <option name=""DEPRECATED_ATTRIBUTES"">
            <value>
                <option name=""EFFECT_COLOR"" value=""{cFgDefault}""/>
                <option name=""EFFECT_TYPE"" value=""3""/>
            </value>
        </option>
        <option name=""DUPLICATE_FROM_SERVER"">
            <value>
                <option name=""FOREGROUND"" value=""{cBgBase}""/>
                <option name=""BACKGROUND"" value=""{cOrangeWarn}""/>
            </value>
        </option>
        <option name=""ERRORS_ATTRIBUTES"">
            <value>
                <option name=""FOREGROUND"" value=""{cRed}""/>
                <option name=""ERROR_STRIPE_COLOR"" value=""{cRed}""/>
                <option name=""EFFECT_TYPE"" value=""2""/>
            </value>
        </option>
        <option name=""FOLDED_TEXT_ATTRIBUTES"">
            <value/>
        </option>
        <option name=""FOLLOWED_HYPERLINK_ATTRIBUTES"">
            <value>
                <option name=""FOREGROUND"" value=""{cPurple}""/>
                <option name=""EFFECT_COLOR"" value=""{cPurple}""/>
                <option name=""EFFECT_TYPE"" value=""1""/>
            </value>
        </option>
        <option name=""GENERIC_SERVER_ERROR_OR_WARNING"">
            <value>
                <option name=""EFFECT_COLOR"" value=""{cRed}""/>
                <option name=""ERROR_STRIPE_COLOR"" value=""{cRed}""/>
                <option name=""EFFECT_TYPE"" value=""1""/>
            </value>
        </option>
        <option name=""HYPERLINK_ATTRIBUTES"">
            <value>
                <option name=""FOREGROUND"" value=""{cMagenta}""/>
                <option name=""EFFECT_COLOR"" value=""{cMagenta}""/>
                <option name=""EFFECT_TYPE"" value=""1""/>
            </value>
        </option>
        <option name=""IDENTIFIER_UNDER_CARET_ATTRIBUTES"">
            <value>
                <option name=""FOREGROUND"" value=""{cOrangeBright}""/>
                <option name=""FONT_TYPE"" value=""1""/>
                <option name=""EFFECT_TYPE"" value=""1""/>
            </value>
        </option>
        <option name=""INACTIVE_HYPERLINK_ATTRIBUTES"">
            <value>
                <option name=""EFFECT_COLOR"" value=""{cFgMuted}""/>
                <option name=""EFFECT_TYPE"" value=""1""/>
            </value>
        </option>
        <option name=""INFO_ATTRIBUTES"">
            <value>
                <option name=""FOREGROUND"" value=""{cOrangeWarn}""/>
                <option name=""ERROR_STRIPE_COLOR"" value=""{cOrangeWarn}""/>
                <option name=""EFFECT_TYPE"" value=""2""/>
            </value>
        </option>
        <option name=""INLAY_DEFAULT"">
            <value>
                <option name=""FOREGROUND"" value=""{cFgDefault}""/>
            </value>
        </option>
        <option name=""INLAY_TEXT_WITHOUT_BACKGROUND"">
            <value>
                <option name=""FOREGROUND"" value=""{cFgDefault}""/>
            </value>
        </option>
        <option name=""INLINE_PARAMETER_HINT"">
            <value>
                <option name=""FOREGROUND"" value=""{cFgMuted}""/>
                <option name=""BACKGROUND"" value=""{cBgHint}""/>
            </value>
        </option>
        <option name=""INLINE_PARAMETER_HINT_CURRENT"">
            <value/>
        </option>
        <option name=""INLINE_PARAMETER_HINT_HIGHLIGHTED"">
            <value/>
        </option>
        <option name=""MARKED_FOR_REMOVAL_ATTRIBUTES"">
            <value>
                <option name=""EFFECT_COLOR"" value=""{cRed}""/>
                <option name=""EFFECT_TYPE"" value=""3""/>
            </value>
        </option>
        <option name=""MATCHED_BRACE_ATTRIBUTES"">
            <value>
                <option name=""FOREGROUND"" value=""{cBlue}""/>
                <option name=""FONT_TYPE"" value=""1""/>
                <option name=""EFFECT_COLOR"" value=""{cBlue}""/>
                <option name=""EFFECT_TYPE"" value=""4""/>
            </value>
        </option>
        <option name=""NOT_USED_ELEMENT_ATTRIBUTES"">
            <value>
                <option name=""EFFECT_COLOR"" value=""{cFgMuted}""/>
                <option name=""EFFECT_TYPE"" value=""1""/>
            </value>
        </option>
        <option name=""RUNTIME_ERROR"">
            <value>
                <option name=""EFFECT_COLOR"" value=""{cRed}""/>
                <option name=""ERROR_STRIPE_COLOR"" value=""{cRed}""/>
                <option name=""EFFECT_TYPE"" value=""5""/>
            </value>
        </option>
        <option name=""ReSharper.BUILTIN_TYPE_KEYWORD"">
            <value>
                <option name=""FOREGROUND"" value=""{cMagenta}""/>
            </value>
        </option>
        <option name=""ReSharper.CONTROL_FLOW_KEYWORD"">
            <value>
                <option name=""FOREGROUND"" value=""{cMagenta}""/>
            </value>
        </option>
        <option name=""ReSharper.CONTROL_TRANSFER_KEYWORD"">
            <value>
                <option name=""FOREGROUND"" value=""{cMagenta}""/>
            </value>
        </option>
        <option name=""ReSharper.CSHARP_TYPE_PARAMETER_IDENTIFIER"">
            <value>
                <option name=""FOREGROUND"" value=""{cGreen}""/>
            </value>
        </option>
        <option name=""ReSharper.FORMAT_STRING_ITEM"">
            <value>
                <option name=""FOREGROUND"" value=""{cFgDefault}""/>
            </value>
        </option>
        <option name=""ReSharper.FORMAT_STRING_ITEM_2"">
            <value>
                <option name=""FOREGROUND"" value=""{cFgDefault}""/>
            </value>
        </option>
        <option name=""ReSharper.HINT"">
            <value>
                <option name=""EFFECT_COLOR"" value=""{cYellow}""/>
                <option name=""ERROR_STRIPE_COLOR"" value=""{cYellow}""/>
                <option name=""EFFECT_TYPE"" value=""5""/>
            </value>
        </option>
        <option name=""ReSharper.MATCHED_FORMAT_STRING_ITEM"">
            <value>
                <option name=""FOREGROUND"" value=""{cFgDefault}""/>
            </value>
        </option>
        <option name=""ReSharper.NAMESPACE_IDENTIFIER"">
            <value>
                <option name=""FOREGROUND"" value=""{cFgDefault}""/>
            </value>
        </option>
        <option name=""ReSharper.OPERATOR_IDENTIFIER"">
            <value>
                <option name=""FOREGROUND"" value=""{cBlue}""/>
            </value>
        </option>
        <option name=""ReSharper.PROPERTY_IDENTIFIER"">
            <value>
                <option name=""FOREGROUND"" value=""{cBlue}""/>
            </value>
        </option>
        <option name=""ReSharper.STRING_ESCAPE_CHARACTER_2"" baseAttributes=""DEFAULT_VALID_STRING_ESCAPE""/>
        <option name=""SEARCH_RESULT_ATTRIBUTES"">
            <value>
                <option name=""FOREGROUND"" value=""{cBgBase}""/>
                <option name=""BACKGROUND"" value=""{cYellow}""/>
                <option name=""EFFECT_COLOR"" value=""{cOrangeWarn}""/>
                <option name=""ERROR_STRIPE_COLOR"" value=""{cYellow}""/>
            </value>
        </option>
        <option name=""SUGGESTION"">
            <value>
                <option name=""EFFECT_COLOR"" value=""{cYellow}""/>
                <option name=""EFFECT_TYPE"" value=""2""/>
            </value>
        </option>
        <option name=""TEMPLATE_VARIABLE_ATTRIBUTES"">
            <value>
                <option name=""FOREGROUND"" value=""{cFgDefault}""/>
            </value>
        </option>
        <option name=""TEXT"">
            <value>
                <option name=""FOREGROUND"" value=""{cFgMuted}""/>
                <option name=""BACKGROUND"" value=""{cBgBase}""/>
                <option name=""EFFECT_TYPE"" value=""5""/>
            </value>
        </option>
        <option name=""TEXT_SEARCH_RESULT_ATTRIBUTES"">
            <value>
                <option name=""FOREGROUND"" value=""{cBgBase}""/>
                <option name=""BACKGROUND"" value=""{cGreenBright}""/>
                <option name=""EFFECT_COLOR"" value=""{cGreen}""/>
                <option name=""ERROR_STRIPE_COLOR"" value=""{cGreenBright}""/>
            </value>
        </option>
        <option name=""TODO_DEFAULT_ATTRIBUTES"">
            <value>
                <option name=""FOREGROUND"" value=""{cGreenLime}""/>
                <option name=""FONT_TYPE"" value=""2""/>
                <option name=""ERROR_STRIPE_COLOR"" value=""{cGreenLime}""/>
            </value>
        </option>
        <option name=""TYPO"">
            <value>
                <option name=""EFFECT_COLOR"" value=""{cOrangeWarn}""/>
                <option name=""EFFECT_TYPE"" value=""2""/>
            </value>
        </option>
        <option name=""UNMATCHED_BRACE_ATTRIBUTES"">
            <value>
                <option name=""FOREGROUND"" value=""{cRed}""/>
                <option name=""ERROR_STRIPE_COLOR"" value=""{cRed}""/>
            </value>
        </option>
        <option name=""WARNING_ATTRIBUTES"">
            <value>
                <option name=""FOREGROUND"" value=""{cOrangeWarn}""/>
                <option name=""ERROR_STRIPE_COLOR"" value=""{cOrangeWarn}""/>
                <option name=""EFFECT_TYPE"" value=""2""/>
            </value>
        </option>
        <option name=""WRITE_IDENTIFIER_UNDER_CARET_ATTRIBUTES"">
            <value>
                <option name=""FOREGROUND"" value=""{cRed}""/>
                <option name=""EFFECT_TYPE"" value=""1""/>
            </value>
        </option>
        <option name=""WRITE_SEARCH_RESULT_ATTRIBUTES"">
            <value>
                <option name=""FOREGROUND"" value=""{cBgBase}""/>
                <option name=""BACKGROUND"" value=""{cRed}""/>
                <option name=""EFFECT_COLOR"" value=""{cRedLight}""/>
                <option name=""ERROR_STRIPE_COLOR"" value=""{cRed}""/>
            </value>
        </option>
    </attributes>
</scheme>";

		return xmlOutput;
	}
}