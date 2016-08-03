using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.iOS.CSS
{
	/// <summary>
	/// Returns requested styles for a DOM node identified by <code>nodeId</code>.
	/// </summary>
	[Command(ProtocolName.CSS.GetMatchedStylesForNode)]
	[SupportedBy("iOS")]
	public class GetMatchedStylesForNodeCommand
	{
		/// <summary>
		/// Gets or sets NodeId
		/// </summary>
		public long NodeId { get; set; }
		/// <summary>
		/// Gets or sets Whether to include pseudo styles (default: true).
		/// </summary>
		public bool IncludePseudo { get; set; }
		/// <summary>
		/// Gets or sets Whether to include inherited styles (default: true).
		/// </summary>
		public bool IncludeInherited { get; set; }
	}
}
