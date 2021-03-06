using MasterDevs.ChromeDevTools;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.DOM
{
	/// <summary>
	/// Fired when <code>Document</code> has been totally updated. Node ids are no longer valid.
	/// </summary>
	[Event(ProtocolName.DOM.DocumentUpdated)]
	[SupportedBy("Chrome")]
	public class DocumentUpdatedEvent
	{
	}
}
