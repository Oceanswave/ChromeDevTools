using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.iOS.CSS
{
	/// <summary>
	/// CSS style effective visual dimensions and source offsets.
	/// </summary>
	[SupportedBy("iOS")]
	public class CSSProperty
	{
		/// <summary>
		/// Gets or sets The property name.
		/// </summary>
		public string Name { get; set; }
		/// <summary>
		/// Gets or sets The property value.
		/// </summary>
		public string Value { get; set; }
		/// <summary>
		/// Gets or sets The property priority (implies "" if absent).
		/// </summary>
		public string Priority { get; set; }
		/// <summary>
		/// Gets or sets Whether the property is implicit (implies <code>false</code> if absent).
		/// </summary>
		public bool Implicit { get; set; }
		/// <summary>
		/// Gets or sets The full property text as specified in the style.
		/// </summary>
		public string Text { get; set; }
		/// <summary>
		/// Gets or sets Whether the property is understood by the browser (implies <code>true</code> if absent).
		/// </summary>
		public bool ParsedOk { get; set; }
		/// <summary>
		/// Gets or sets Whether the property is active or disabled.
		/// </summary>
		public CSSPropertyStatus Status { get; set; }
		/// <summary>
		/// Gets or sets The entire property range in the enclosing style declaration (if available).
		/// </summary>
		public SourceRange Range { get; set; }
	}
}
