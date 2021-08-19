using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class PSD_DetectorPS : gameDeviceComponentPS
	{
		private CInt32 _counter;
		private CBool _toggle;
		private entEntityID _lastEntityID;
		private gamePersistentID _lastPersistentID;
		private CName _name;

		[Ordinal(13)] 
		[RED("counter")] 
		public CInt32 Counter
		{
			get => GetProperty(ref _counter);
			set => SetProperty(ref _counter, value);
		}

		[Ordinal(14)] 
		[RED("toggle")] 
		public CBool Toggle
		{
			get => GetProperty(ref _toggle);
			set => SetProperty(ref _toggle, value);
		}

		[Ordinal(15)] 
		[RED("lastEntityID")] 
		public entEntityID LastEntityID
		{
			get => GetProperty(ref _lastEntityID);
			set => SetProperty(ref _lastEntityID, value);
		}

		[Ordinal(16)] 
		[RED("lastPersistentID")] 
		public gamePersistentID LastPersistentID
		{
			get => GetProperty(ref _lastPersistentID);
			set => SetProperty(ref _lastPersistentID, value);
		}

		[Ordinal(17)] 
		[RED("name")] 
		public CName Name
		{
			get => GetProperty(ref _name);
			set => SetProperty(ref _name, value);
		}

		public PSD_DetectorPS(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
