using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class DestroyWeakspotEffector : gameEffector
	{
		private CInt32 _weakspotIndex;

		[Ordinal(0)] 
		[RED("weakspotIndex")] 
		public CInt32 WeakspotIndex
		{
			get => GetProperty(ref _weakspotIndex);
			set => SetProperty(ref _weakspotIndex, value);
		}

		public DestroyWeakspotEffector(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
