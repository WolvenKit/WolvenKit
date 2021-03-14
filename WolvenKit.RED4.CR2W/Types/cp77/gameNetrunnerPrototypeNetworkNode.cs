using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameNetrunnerPrototypeNetworkNode : gameObject
	{
		private CInt8 _colorIndex;

		[Ordinal(40)] 
		[RED("colorIndex")] 
		public CInt8 ColorIndex
		{
			get
			{
				if (_colorIndex == null)
				{
					_colorIndex = (CInt8) CR2WTypeManager.Create("Int8", "colorIndex", cr2w, this);
				}
				return _colorIndex;
			}
			set
			{
				if (_colorIndex == value)
				{
					return;
				}
				_colorIndex = value;
				PropertySet(this);
			}
		}

		public gameNetrunnerPrototypeNetworkNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
