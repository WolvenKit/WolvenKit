using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class inkanimMarkerEvent : inkanimEvent
	{
		private CName _markerName;

		[Ordinal(1)] 
		[RED("markerName")] 
		public CName MarkerName
		{
			get
			{
				if (_markerName == null)
				{
					_markerName = (CName) CR2WTypeManager.Create("CName", "markerName", cr2w, this);
				}
				return _markerName;
			}
			set
			{
				if (_markerName == value)
				{
					return;
				}
				_markerName = value;
				PropertySet(this);
			}
		}

		public inkanimMarkerEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
