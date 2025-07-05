using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class scnDialogLineData : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("id")] 
		public CRUID Id
		{
			get => GetPropertyValue<CRUID>();
			set => SetPropertyValue<CRUID>(value);
		}

		[Ordinal(1)] 
		[RED("text")] 
		public CString Text
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(2)] 
		[RED("type")] 
		public CEnum<scnDialogLineType> Type
		{
			get => GetPropertyValue<CEnum<scnDialogLineType>>();
			set => SetPropertyValue<CEnum<scnDialogLineType>>(value);
		}

		[Ordinal(3)] 
		[RED("speaker")] 
		public CWeakHandle<gameObject> Speaker
		{
			get => GetPropertyValue<CWeakHandle<gameObject>>();
			set => SetPropertyValue<CWeakHandle<gameObject>>(value);
		}

		[Ordinal(4)] 
		[RED("speakerName")] 
		public CString SpeakerName
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(5)] 
		[RED("isPersistent")] 
		public CBool IsPersistent
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(6)] 
		[RED("duration")] 
		public CFloat Duration
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public scnDialogLineData()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
