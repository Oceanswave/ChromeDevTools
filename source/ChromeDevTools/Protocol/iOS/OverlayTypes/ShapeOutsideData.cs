using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.iOS.OverlayTypes
{
	/// <summary>
	/// 
	/// </summary>
	[SupportedBy("iOS")]
	public class ShapeOutsideData
	{
		/// <summary>
		/// Gets or sets Bounds for the shape-outside paths.
		/// </summary>
		public Point[] Bounds { get; set; }
		/// <summary>
		/// Gets or sets Path for the element's shape.
		/// </summary>
		public object[] Shape { get; set; }
		/// <summary>
		/// Gets or sets Path for the element's margin shape.
		/// </summary>
		public object[] MarginShape { get; set; }
	}
}
