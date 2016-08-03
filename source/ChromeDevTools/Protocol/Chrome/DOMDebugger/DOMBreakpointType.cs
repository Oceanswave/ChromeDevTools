using MasterDevs.ChromeDevTools;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.DOMDebugger{
	/// <summary>
	/// DOM breakpoint type.
	/// </summary>
	public enum DOMBreakpointType
	{
			Subtree_modified,
			Attribute_modified,
			Node_removed,
	}
}
