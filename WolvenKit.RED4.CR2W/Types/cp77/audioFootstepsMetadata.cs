using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioFootstepsMetadata : audioAudioMetadata
	{
		private CName _defaultFootwearMetadata;
		private CArray<CName> _footwearMetadataArray;
		private CName _slideEvent;
		private CName _onEnterSound;
		private CName _onExitSound;

		[Ordinal(1)] 
		[RED("defaultFootwearMetadata")] 
		public CName DefaultFootwearMetadata
		{
			get => GetProperty(ref _defaultFootwearMetadata);
			set => SetProperty(ref _defaultFootwearMetadata, value);
		}

		[Ordinal(2)] 
		[RED("footwearMetadataArray")] 
		public CArray<CName> FootwearMetadataArray
		{
			get => GetProperty(ref _footwearMetadataArray);
			set => SetProperty(ref _footwearMetadataArray, value);
		}

		[Ordinal(3)] 
		[RED("slideEvent")] 
		public CName SlideEvent
		{
			get => GetProperty(ref _slideEvent);
			set => SetProperty(ref _slideEvent, value);
		}

		[Ordinal(4)] 
		[RED("onEnterSound")] 
		public CName OnEnterSound
		{
			get => GetProperty(ref _onEnterSound);
			set => SetProperty(ref _onEnterSound, value);
		}

		[Ordinal(5)] 
		[RED("onExitSound")] 
		public CName OnExitSound
		{
			get => GetProperty(ref _onExitSound);
			set => SetProperty(ref _onExitSound, value);
		}

		public audioFootstepsMetadata(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
