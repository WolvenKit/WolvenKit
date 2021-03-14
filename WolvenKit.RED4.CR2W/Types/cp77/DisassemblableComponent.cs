using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class DisassemblableComponent : gameScriptableComponent
	{
		private CBool _disassembled;
		private CArray<wCHandle<gameObject>> _disassembleTargetRequesters;

		[Ordinal(5)] 
		[RED("disassembled")] 
		public CBool Disassembled
		{
			get
			{
				if (_disassembled == null)
				{
					_disassembled = (CBool) CR2WTypeManager.Create("Bool", "disassembled", cr2w, this);
				}
				return _disassembled;
			}
			set
			{
				if (_disassembled == value)
				{
					return;
				}
				_disassembled = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("disassembleTargetRequesters")] 
		public CArray<wCHandle<gameObject>> DisassembleTargetRequesters
		{
			get
			{
				if (_disassembleTargetRequesters == null)
				{
					_disassembleTargetRequesters = (CArray<wCHandle<gameObject>>) CR2WTypeManager.Create("array:whandle:gameObject", "disassembleTargetRequesters", cr2w, this);
				}
				return _disassembleTargetRequesters;
			}
			set
			{
				if (_disassembleTargetRequesters == value)
				{
					return;
				}
				_disassembleTargetRequesters = value;
				PropertySet(this);
			}
		}

		public DisassemblableComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
