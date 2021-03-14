using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gamehitRepresentationEventsSetSingleScaleMultiplier_SingleShape : gamehitRepresentationEventsSetSingleScaleMultiplier_AllShapes
	{
		private CName _shapeName;

		[Ordinal(1)] 
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

		public gamehitRepresentationEventsSetSingleScaleMultiplier_SingleShape(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
