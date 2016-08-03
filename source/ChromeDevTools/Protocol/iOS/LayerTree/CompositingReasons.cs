using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.iOS.LayerTree
{
	/// <summary>
	/// An object containing the reasons why the layer was composited as properties.
	/// </summary>
	[SupportedBy("iOS")]
	public class CompositingReasons
	{
		/// <summary>
		/// Gets or sets Composition due to association with an element with a CSS 3D transform.
		/// </summary>
		public bool Transform3D { get; set; }
		/// <summary>
		/// Gets or sets Composition due to association with a <video> element.
		/// </summary>
		public bool Video { get; set; }
		/// <summary>
		/// Gets or sets Composition due to the element being a <canvas> element.
		/// </summary>
		public bool Canvas { get; set; }
		/// <summary>
		/// Gets or sets Composition due to association with a plugin.
		/// </summary>
		public bool Plugin { get; set; }
		/// <summary>
		/// Gets or sets Composition due to association with an <iframe> element.
		/// </summary>
		public bool IFrame { get; set; }
		/// <summary>
		/// Gets or sets Composition due to association with an element with a "backface-visibility: hidden" style.
		/// </summary>
		public bool BackfaceVisibilityHidden { get; set; }
		/// <summary>
		/// Gets or sets Composition due to association with an element clipping compositing descendants.
		/// </summary>
		public bool ClipsCompositingDescendants { get; set; }
		/// <summary>
		/// Gets or sets Composition due to association with an animated element.
		/// </summary>
		public bool Animation { get; set; }
		/// <summary>
		/// Gets or sets Composition due to association with an element with CSS filters applied.
		/// </summary>
		public bool Filters { get; set; }
		/// <summary>
		/// Gets or sets Composition due to association with an element with a "position: fixed" style.
		/// </summary>
		public bool PositionFixed { get; set; }
		/// <summary>
		/// Gets or sets Composition due to association with an element with a "position: sticky" style.
		/// </summary>
		public bool PositionSticky { get; set; }
		/// <summary>
		/// Gets or sets Composition due to association with an element with a "overflow-scrolling: touch" style.
		/// </summary>
		public bool OverflowScrollingTouch { get; set; }
		/// <summary>
		/// Gets or sets Composition due to association with an element establishing a stacking context.
		/// </summary>
		public bool Stacking { get; set; }
		/// <summary>
		/// Gets or sets Composition due to association with an element overlapping other composited elements.
		/// </summary>
		public bool Overlap { get; set; }
		/// <summary>
		/// Gets or sets Composition due to association with an element with descendants that have a negative z-index.
		/// </summary>
		public bool NegativeZIndexChildren { get; set; }
		/// <summary>
		/// Gets or sets Composition due to association with an element with composited descendants.
		/// </summary>
		public bool TransformWithCompositedDescendants { get; set; }
		/// <summary>
		/// Gets or sets Composition due to association with an element with opacity applied and composited descendants.
		/// </summary>
		public bool OpacityWithCompositedDescendants { get; set; }
		/// <summary>
		/// Gets or sets Composition due to association with a masked element and composited descendants.
		/// </summary>
		public bool MaskWithCompositedDescendants { get; set; }
		/// <summary>
		/// Gets or sets Composition due to association with an element with a reflection and composited descendants.
		/// </summary>
		public bool ReflectionWithCompositedDescendants { get; set; }
		/// <summary>
		/// Gets or sets Composition due to association with an element with CSS filters applied and composited descendants.
		/// </summary>
		public bool FilterWithCompositedDescendants { get; set; }
		/// <summary>
		/// Gets or sets Composition due to association with an element with CSS blending applied and composited descendants.
		/// </summary>
		public bool BlendingWithCompositedDescendants { get; set; }
		/// <summary>
		/// Gets or sets Composition due to association with an element isolating compositing descendants having CSS blending applied.
		/// </summary>
		public bool IsolatesCompositedBlendingDescendants { get; set; }
		/// <summary>
		/// Gets or sets Composition due to association with an element with perspective applied.
		/// </summary>
		public bool Perspective { get; set; }
		/// <summary>
		/// Gets or sets Composition due to association with an element with a "transform-style: preserve-3d" style.
		/// </summary>
		public bool Preserve3D { get; set; }
		/// <summary>
		/// Gets or sets Composition due to association with an element with a "will-change" style.
		/// </summary>
		public bool WillChange { get; set; }
		/// <summary>
		/// Gets or sets Composition due to association with the root element.
		/// </summary>
		public bool Root { get; set; }
		/// <summary>
		/// Gets or sets Composition due to association with an element with a "blend-mode" style.
		/// </summary>
		public bool Blending { get; set; }
	}
}
