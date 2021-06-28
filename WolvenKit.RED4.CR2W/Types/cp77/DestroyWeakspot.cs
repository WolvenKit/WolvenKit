using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class DestroyWeakspot : AIActionHelperTask
	{
		private CInt32 _weakspotIndex;
		private CHandle<gameWeakspotComponent> _weakspotComponent;
		private CArray<wCHandle<gameWeakspotObject>> _weakspotArray;

		[Ordinal(5)] 
		[RED("weakspotIndex")] 
		public CInt32 WeakspotIndex
		{
			get => GetProperty(ref _weakspotIndex);
			set => SetProperty(ref _weakspotIndex, value);
		}

		[Ordinal(6)] 
		[RED("weakspotComponent")] 
		public CHandle<gameWeakspotComponent> WeakspotComponent
		{
			get => GetProperty(ref _weakspotComponent);
			set => SetProperty(ref _weakspotComponent, value);
		}

		[Ordinal(7)] 
		[RED("weakspotArray")] 
		public CArray<wCHandle<gameWeakspotObject>> WeakspotArray
		{
			get => GetProperty(ref _weakspotArray);
			set => SetProperty(ref _weakspotArray, value);
		}

		public DestroyWeakspot(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
