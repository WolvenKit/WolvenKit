using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ShardEntryData : GenericCodexEntryData
	{
		private CBool _isCrypted;

		[Ordinal(10)] 
		[RED("isCrypted")] 
		public CBool IsCrypted
		{
			get
			{
				if (_isCrypted == null)
				{
					_isCrypted = (CBool) CR2WTypeManager.Create("Bool", "isCrypted", cr2w, this);
				}
				return _isCrypted;
			}
			set
			{
				if (_isCrypted == value)
				{
					return;
				}
				_isCrypted = value;
				PropertySet(this);
			}
		}

		public ShardEntryData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
