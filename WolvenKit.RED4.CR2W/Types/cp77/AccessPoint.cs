using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AccessPoint : InteractiveMasterDevice
	{
		private CHandle<gameLightComponent> _diode0;
		private CHandle<gameLightComponent> _diode1;
		private CHandle<gameLightComponent> _diode2;
		private CHandle<gameLightComponent> _diode3;
		private CFloat _elapsedTime;
		private CBool _turnOnLight;
		private CString _networkName;
		private CBool _isPlayerInBreachView;
		private CBool _isRevealed;
		private CHandle<BreachViewTimeListener> _breachViewTimeListener;
		private CUInt32 _upload_program_listener_id;

		[Ordinal(96)] 
		[RED("diode0")] 
		public CHandle<gameLightComponent> Diode0
		{
			get => GetProperty(ref _diode0);
			set => SetProperty(ref _diode0, value);
		}

		[Ordinal(97)] 
		[RED("diode1")] 
		public CHandle<gameLightComponent> Diode1
		{
			get => GetProperty(ref _diode1);
			set => SetProperty(ref _diode1, value);
		}

		[Ordinal(98)] 
		[RED("diode2")] 
		public CHandle<gameLightComponent> Diode2
		{
			get => GetProperty(ref _diode2);
			set => SetProperty(ref _diode2, value);
		}

		[Ordinal(99)] 
		[RED("diode3")] 
		public CHandle<gameLightComponent> Diode3
		{
			get => GetProperty(ref _diode3);
			set => SetProperty(ref _diode3, value);
		}

		[Ordinal(100)] 
		[RED("elapsedTime")] 
		public CFloat ElapsedTime
		{
			get => GetProperty(ref _elapsedTime);
			set => SetProperty(ref _elapsedTime, value);
		}

		[Ordinal(101)] 
		[RED("turnOnLight")] 
		public CBool TurnOnLight
		{
			get => GetProperty(ref _turnOnLight);
			set => SetProperty(ref _turnOnLight, value);
		}

		[Ordinal(102)] 
		[RED("networkName")] 
		public CString NetworkName
		{
			get => GetProperty(ref _networkName);
			set => SetProperty(ref _networkName, value);
		}

		[Ordinal(103)] 
		[RED("isPlayerInBreachView")] 
		public CBool IsPlayerInBreachView
		{
			get => GetProperty(ref _isPlayerInBreachView);
			set => SetProperty(ref _isPlayerInBreachView, value);
		}

		[Ordinal(104)] 
		[RED("isRevealed")] 
		public CBool IsRevealed
		{
			get => GetProperty(ref _isRevealed);
			set => SetProperty(ref _isRevealed, value);
		}

		[Ordinal(105)] 
		[RED("breachViewTimeListener")] 
		public CHandle<BreachViewTimeListener> BreachViewTimeListener
		{
			get => GetProperty(ref _breachViewTimeListener);
			set => SetProperty(ref _breachViewTimeListener, value);
		}

		[Ordinal(106)] 
		[RED("upload_program_listener_id")] 
		public CUInt32 Upload_program_listener_id
		{
			get => GetProperty(ref _upload_program_listener_id);
			set => SetProperty(ref _upload_program_listener_id, value);
		}

		public AccessPoint(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
