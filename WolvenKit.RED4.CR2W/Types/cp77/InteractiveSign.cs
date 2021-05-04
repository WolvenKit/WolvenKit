using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class InteractiveSign : Device
	{
		private CEnum<SignShape> _signShape;
		private CEnum<SignType> _type;
		private CString _message;

		[Ordinal(86)] 
		[RED("signShape")] 
		public CEnum<SignShape> SignShape
		{
			get => GetProperty(ref _signShape);
			set => SetProperty(ref _signShape, value);
		}

		[Ordinal(87)] 
		[RED("type")] 
		public CEnum<SignType> Type
		{
			get => GetProperty(ref _type);
			set => SetProperty(ref _type, value);
		}

		[Ordinal(88)] 
		[RED("message")] 
		public CString Message
		{
			get => GetProperty(ref _message);
			set => SetProperty(ref _message, value);
		}

		public InteractiveSign(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
