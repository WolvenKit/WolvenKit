using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gamemappinsOutlineMappinVolume : gamemappinsIMappinVolume
	{
		private CFloat _height;
		private CArray<Vector2> _outlinePoints;

		[Ordinal(0)] 
		[RED("height")] 
		public CFloat Height
		{
			get
			{
				if (_height == null)
				{
					_height = (CFloat) CR2WTypeManager.Create("Float", "height", cr2w, this);
				}
				return _height;
			}
			set
			{
				if (_height == value)
				{
					return;
				}
				_height = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("outlinePoints")] 
		public CArray<Vector2> OutlinePoints
		{
			get
			{
				if (_outlinePoints == null)
				{
					_outlinePoints = (CArray<Vector2>) CR2WTypeManager.Create("array:Vector2", "outlinePoints", cr2w, this);
				}
				return _outlinePoints;
			}
			set
			{
				if (_outlinePoints == value)
				{
					return;
				}
				_outlinePoints = value;
				PropertySet(this);
			}
		}

		public gamemappinsOutlineMappinVolume(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
