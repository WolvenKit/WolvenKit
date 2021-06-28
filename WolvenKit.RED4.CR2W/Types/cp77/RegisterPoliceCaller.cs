using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class RegisterPoliceCaller : gameScriptableSystemRequest
	{
		private wCHandle<entEntity> _caller;
		private Vector4 _crimePosition;

		[Ordinal(0)] 
		[RED("caller")] 
		public wCHandle<entEntity> Caller
		{
			get => GetProperty(ref _caller);
			set => SetProperty(ref _caller, value);
		}

		[Ordinal(1)] 
		[RED("crimePosition")] 
		public Vector4 CrimePosition
		{
			get => GetProperty(ref _crimePosition);
			set => SetProperty(ref _crimePosition, value);
		}

		public RegisterPoliceCaller(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
