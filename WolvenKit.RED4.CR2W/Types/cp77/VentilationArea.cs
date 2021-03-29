using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class VentilationArea : InteractiveMasterDevice
	{
		private CHandle<gameStaticTriggerAreaComponent> _areaComponent;
		private CBool _restartGameEffectOnAttach;
		private CString _attackRecord;
		private gameEffectRef _gameEffectRef;
		private CHandle<gameEffectInstance> _gameEffect;
		private CBool _highLightActive;

		[Ordinal(96)] 
		[RED("areaComponent")] 
		public CHandle<gameStaticTriggerAreaComponent> AreaComponent
		{
			get => GetProperty(ref _areaComponent);
			set => SetProperty(ref _areaComponent, value);
		}

		[Ordinal(97)] 
		[RED("RestartGameEffectOnAttach")] 
		public CBool RestartGameEffectOnAttach
		{
			get => GetProperty(ref _restartGameEffectOnAttach);
			set => SetProperty(ref _restartGameEffectOnAttach, value);
		}

		[Ordinal(98)] 
		[RED("AttackRecord")] 
		public CString AttackRecord
		{
			get => GetProperty(ref _attackRecord);
			set => SetProperty(ref _attackRecord, value);
		}

		[Ordinal(99)] 
		[RED("gameEffectRef")] 
		public gameEffectRef GameEffectRef
		{
			get => GetProperty(ref _gameEffectRef);
			set => SetProperty(ref _gameEffectRef, value);
		}

		[Ordinal(100)] 
		[RED("gameEffect")] 
		public CHandle<gameEffectInstance> GameEffect
		{
			get => GetProperty(ref _gameEffect);
			set => SetProperty(ref _gameEffect, value);
		}

		[Ordinal(101)] 
		[RED("highLightActive")] 
		public CBool HighLightActive
		{
			get => GetProperty(ref _highLightActive);
			set => SetProperty(ref _highLightActive, value);
		}

		public VentilationArea(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
