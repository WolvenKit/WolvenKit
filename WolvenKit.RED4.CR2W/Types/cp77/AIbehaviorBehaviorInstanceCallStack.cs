using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorBehaviorInstanceCallStack : CVariable
	{
		private CArray<CUInt32> _resourceHashes;

		[Ordinal(0)] 
		[RED("resourceHashes")] 
		public CArray<CUInt32> ResourceHashes
		{
			get
			{
				if (_resourceHashes == null)
				{
					_resourceHashes = (CArray<CUInt32>) CR2WTypeManager.Create("array:Uint32", "resourceHashes", cr2w, this);
				}
				return _resourceHashes;
			}
			set
			{
				if (_resourceHashes == value)
				{
					return;
				}
				_resourceHashes = value;
				PropertySet(this);
			}
		}

		public AIbehaviorBehaviorInstanceCallStack(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
