using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gamehitRepresentationEventsResetSingleScaleMultiplier : redEvent
	{
		private CName _shapeName;

		[Ordinal(0)] 
		[RED("shapeName")] 
		public CName ShapeName
		{
			get
			{
				if (_shapeName == null)
				{
					_shapeName = (CName) CR2WTypeManager.Create("CName", "shapeName", cr2w, this);
				}
				return _shapeName;
			}
			set
			{
				if (_shapeName == value)
				{
					return;
				}
				_shapeName = value;
				PropertySet(this);
			}
		}

		public gamehitRepresentationEventsResetSingleScaleMultiplier(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
