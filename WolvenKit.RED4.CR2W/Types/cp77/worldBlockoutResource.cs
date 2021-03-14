using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldBlockoutResource : CResource
	{
		private CHandle<worldBlockoutData> _blockoutData;

		[Ordinal(1)] 
		[RED("blockoutData")] 
		public CHandle<worldBlockoutData> BlockoutData
		{
			get
			{
				if (_blockoutData == null)
				{
					_blockoutData = (CHandle<worldBlockoutData>) CR2WTypeManager.Create("handle:worldBlockoutData", "blockoutData", cr2w, this);
				}
				return _blockoutData;
			}
			set
			{
				if (_blockoutData == value)
				{
					return;
				}
				_blockoutData = value;
				PropertySet(this);
			}
		}

		public worldBlockoutResource(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
