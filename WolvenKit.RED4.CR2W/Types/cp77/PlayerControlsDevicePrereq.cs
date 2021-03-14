using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class PlayerControlsDevicePrereq : gameIScriptablePrereq
	{
		private CBool _inverse;

		[Ordinal(0)] 
		[RED("inverse")] 
		public CBool Inverse
		{
			get
			{
				if (_inverse == null)
				{
					_inverse = (CBool) CR2WTypeManager.Create("Bool", "inverse", cr2w, this);
				}
				return _inverse;
			}
			set
			{
				if (_inverse == value)
				{
					return;
				}
				_inverse = value;
				PropertySet(this);
			}
		}

		public PlayerControlsDevicePrereq(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
