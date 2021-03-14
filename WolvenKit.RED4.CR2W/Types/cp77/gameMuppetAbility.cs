using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameMuppetAbility : CVariable
	{
		private CInt32 _value;
		private CInt32 _blocks;

		[Ordinal(0)] 
		[RED("value")] 
		public CInt32 Value
		{
			get
			{
				if (_value == null)
				{
					_value = (CInt32) CR2WTypeManager.Create("Int32", "value", cr2w, this);
				}
				return _value;
			}
			set
			{
				if (_value == value)
				{
					return;
				}
				_value = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("blocks")] 
		public CInt32 Blocks
		{
			get
			{
				if (_blocks == null)
				{
					_blocks = (CInt32) CR2WTypeManager.Create("Int32", "blocks", cr2w, this);
				}
				return _blocks;
			}
			set
			{
				if (_blocks == value)
				{
					return;
				}
				_blocks = value;
				PropertySet(this);
			}
		}

		public gameMuppetAbility(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
