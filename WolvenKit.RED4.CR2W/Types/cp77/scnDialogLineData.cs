using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class scnDialogLineData : CVariable
	{
		private CRUID _id;
		private CString _text;
		private CEnum<scnDialogLineType> _type;
		private wCHandle<gameObject> _speaker;
		private CString _speakerName;
		private CBool _isPersistent;
		private CFloat _duration;

		[Ordinal(0)] 
		[RED("id")] 
		public CRUID Id
		{
			get => GetProperty(ref _id);
			set => SetProperty(ref _id, value);
		}

		[Ordinal(1)] 
		[RED("text")] 
		public CString Text
		{
			get => GetProperty(ref _text);
			set => SetProperty(ref _text, value);
		}

		[Ordinal(2)] 
		[RED("type")] 
		public CEnum<scnDialogLineType> Type
		{
			get => GetProperty(ref _type);
			set => SetProperty(ref _type, value);
		}

		[Ordinal(3)] 
		[RED("speaker")] 
		public wCHandle<gameObject> Speaker
		{
			get => GetProperty(ref _speaker);
			set => SetProperty(ref _speaker, value);
		}

		[Ordinal(4)] 
		[RED("speakerName")] 
		public CString SpeakerName
		{
			get => GetProperty(ref _speakerName);
			set => SetProperty(ref _speakerName, value);
		}

		[Ordinal(5)] 
		[RED("isPersistent")] 
		public CBool IsPersistent
		{
			get => GetProperty(ref _isPersistent);
			set => SetProperty(ref _isPersistent, value);
		}

		[Ordinal(6)] 
		[RED("duration")] 
		public CFloat Duration
		{
			get => GetProperty(ref _duration);
			set => SetProperty(ref _duration, value);
		}

		public scnDialogLineData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
