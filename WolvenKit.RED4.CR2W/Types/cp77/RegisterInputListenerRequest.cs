using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class RegisterInputListenerRequest : gameScriptableSystemRequest
	{
		private wCHandle<gameObject> _object;

		[Ordinal(0)] 
		[RED("object")] 
		public wCHandle<gameObject> Object
		{
			get => GetProperty(ref _object);
			set => SetProperty(ref _object, value);
		}

		public RegisterInputListenerRequest(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
