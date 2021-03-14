using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questSetFOV_NodeType : questISceneManagerNodeType
	{
		private CFloat _fOV;

		[Ordinal(0)] 
		[RED("FOV")] 
		public CFloat FOV
		{
			get
			{
				if (_fOV == null)
				{
					_fOV = (CFloat) CR2WTypeManager.Create("Float", "FOV", cr2w, this);
				}
				return _fOV;
			}
			set
			{
				if (_fOV == value)
				{
					return;
				}
				_fOV = value;
				PropertySet(this);
			}
		}

		public questSetFOV_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
