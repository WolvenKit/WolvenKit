using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class DisassembleOptions : CVariable
	{
		private CBool _canBeDisassembled;

		[Ordinal(0)] 
		[RED("canBeDisassembled")] 
		public CBool CanBeDisassembled
		{
			get
			{
				if (_canBeDisassembled == null)
				{
					_canBeDisassembled = (CBool) CR2WTypeManager.Create("Bool", "canBeDisassembled", cr2w, this);
				}
				return _canBeDisassembled;
			}
			set
			{
				if (_canBeDisassembled == value)
				{
					return;
				}
				_canBeDisassembled = value;
				PropertySet(this);
			}
		}

		public DisassembleOptions(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
