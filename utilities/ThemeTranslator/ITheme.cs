namespace ColorschemeUtils;

public interface ITheme
{
	string FilePath { get; set; }
	ColorScheme Scheme { get; set; }
}