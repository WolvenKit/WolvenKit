using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SecuritySystem : DeviceSystemBase
	{
		private CArray<OutputValidationDataStruct> _savedOutputCache;

		[Ordinal(93)] 
		[RED("savedOutputCache")] 
		public CArray<OutputValidationDataStruct> SavedOutputCache
		{
			get
			{
				if (_savedOutputCache == null)
				{
					_savedOutputCache = (CArray<OutputValidationDataStruct>) CR2WTypeManager.Create("array:OutputValidationDataStruct", "savedOutputCache", cr2w, this);
				}
				return _savedOutputCache;
			}
			set
			{
				if (_savedOutputCache == value)
				{
					return;
				}
				_savedOutputCache = value;
				PropertySet(this);
			}
		}

		public SecuritySystem(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
