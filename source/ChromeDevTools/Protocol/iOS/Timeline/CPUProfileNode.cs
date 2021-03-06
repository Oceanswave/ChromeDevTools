using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.iOS.Timeline
{
	/// <summary>
	/// CPU Profile node. Holds callsite information, execution statistics and child nodes.
	/// </summary>
	[SupportedBy("iOS")]
	public class CPUProfileNode
	{
		/// <summary>
		/// Gets or sets Unique identifier for this call site.
		/// </summary>
		public long Id { get; set; }
		/// <summary>
		/// Gets or sets Aggregate info about all the calls that making up this node.
		/// </summary>
		public CPUProfileNodeAggregateCallInfo CallInfo { get; set; }
		/// <summary>
		/// Gets or sets Function name.
		/// </summary>
		public string FunctionName { get; set; }
		/// <summary>
		/// Gets or sets URL.
		/// </summary>
		public string Url { get; set; }
		/// <summary>
		/// Gets or sets Line number.
		/// </summary>
		public long LineNumber { get; set; }
		/// <summary>
		/// Gets or sets Column number.
		/// </summary>
		public long ColumnNumber { get; set; }
		/// <summary>
		/// Gets or sets Child nodes.
		/// </summary>
		public CPUProfileNode[] Children { get; set; }
	}
}
