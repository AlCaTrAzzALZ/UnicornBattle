#if !DISABLE_PLAYFABCLIENT_API
using PlayFab.ClientModels;

namespace PlayFab.Events
{
    public partial class PlayFabEvents
    {
        public event PlayFabResultEvent<LoginResult> OnLoginResultEvent;

        public event PlayFabRequestEvent<GetPhotonAuthenticationTokenRequest> OnGetPhotonAuthenticationTokenRequestEvent;
        public event PlayFabResultEvent<GetPhotonAuthenticationTokenResult> OnGetPhotonAuthenticationTokenResultEvent;
        public event PlayFabRequestEvent<GetWindowsHelloChallengeRequest> OnGetWindowsHelloChallengeRequestEvent;
        public event PlayFabResultEvent<GetWindowsHelloChallengeResponse> OnGetWindowsHelloChallengeResultEvent;
        public event PlayFabRequestEvent<LoginWithAndroidDeviceIDRequest> OnLoginWithAndroidDeviceIDRequestEvent;
        public event PlayFabRequestEvent<LoginWithCustomIDRequest> OnLoginWithCustomIDRequestEvent;
        public event PlayFabRequestEvent<LoginWithEmailAddressRequest> OnLoginWithEmailAddressRequestEvent;
        public event PlayFabRequestEvent<LoginWithFacebookRequest> OnLoginWithFacebookRequestEvent;
        public event PlayFabRequestEvent<LoginWithGameCenterRequest> OnLoginWithGameCenterRequestEvent;
        public event PlayFabRequestEvent<LoginWithGoogleAccountRequest> OnLoginWithGoogleAccountRequestEvent;
        public event PlayFabRequestEvent<LoginWithIOSDeviceIDRequest> OnLoginWithIOSDeviceIDRequestEvent;
        public event PlayFabRequestEvent<LoginWithKongregateRequest> OnLoginWithKongregateRequestEvent;
        public event PlayFabRequestEvent<LoginWithPlayFabRequest> OnLoginWithPlayFabRequestEvent;
        public event PlayFabRequestEvent<LoginWithSteamRequest> OnLoginWithSteamRequestEvent;
        public event PlayFabRequestEvent<LoginWithTwitchRequest> OnLoginWithTwitchRequestEvent;
        public event PlayFabRequestEvent<LoginWithWindowsHelloRequest> OnLoginWithWindowsHelloRequestEvent;
        public event PlayFabRequestEvent<RegisterPlayFabUserRequest> OnRegisterPlayFabUserRequestEvent;
        public event PlayFabResultEvent<RegisterPlayFabUserResult> OnRegisterPlayFabUserResultEvent;
        public event PlayFabRequestEvent<RegisterWithWindowsHelloRequest> OnRegisterWithWindowsHelloRequestEvent;
        public event PlayFabRequestEvent<AddGenericIDRequest> OnAddGenericIDRequestEvent;
        public event PlayFabResultEvent<AddGenericIDResult> OnAddGenericIDResultEvent;
        public event PlayFabRequestEvent<AddUsernamePasswordRequest> OnAddUsernamePasswordRequestEvent;
        public event PlayFabResultEvent<AddUsernamePasswordResult> OnAddUsernamePasswordResultEvent;
        public event PlayFabRequestEvent<GetAccountInfoRequest> OnGetAccountInfoRequestEvent;
        public event PlayFabResultEvent<GetAccountInfoResult> OnGetAccountInfoResultEvent;
        public event PlayFabRequestEvent<GetPlayerCombinedInfoRequest> OnGetPlayerCombinedInfoRequestEvent;
        public event PlayFabResultEvent<GetPlayerCombinedInfoResult> OnGetPlayerCombinedInfoResultEvent;
        public event PlayFabRequestEvent<GetPlayFabIDsFromFacebookIDsRequest> OnGetPlayFabIDsFromFacebookIDsRequestEvent;
        public event PlayFabResultEvent<GetPlayFabIDsFromFacebookIDsResult> OnGetPlayFabIDsFromFacebookIDsResultEvent;
        public event PlayFabRequestEvent<GetPlayFabIDsFromGameCenterIDsRequest> OnGetPlayFabIDsFromGameCenterIDsRequestEvent;
        public event PlayFabResultEvent<GetPlayFabIDsFromGameCenterIDsResult> OnGetPlayFabIDsFromGameCenterIDsResultEvent;
        public event PlayFabRequestEvent<GetPlayFabIDsFromGenericIDsRequest> OnGetPlayFabIDsFromGenericIDsRequestEvent;
        public event PlayFabResultEvent<GetPlayFabIDsFromGenericIDsResult> OnGetPlayFabIDsFromGenericIDsResultEvent;
        public event PlayFabRequestEvent<GetPlayFabIDsFromGoogleIDsRequest> OnGetPlayFabIDsFromGoogleIDsRequestEvent;
        public event PlayFabResultEvent<GetPlayFabIDsFromGoogleIDsResult> OnGetPlayFabIDsFromGoogleIDsResultEvent;
        public event PlayFabRequestEvent<GetPlayFabIDsFromKongregateIDsRequest> OnGetPlayFabIDsFromKongregateIDsRequestEvent;
        public event PlayFabResultEvent<GetPlayFabIDsFromKongregateIDsResult> OnGetPlayFabIDsFromKongregateIDsResultEvent;
        public event PlayFabRequestEvent<GetPlayFabIDsFromSteamIDsRequest> OnGetPlayFabIDsFromSteamIDsRequestEvent;
        public event PlayFabResultEvent<GetPlayFabIDsFromSteamIDsResult> OnGetPlayFabIDsFromSteamIDsResultEvent;
        public event PlayFabRequestEvent<GetPlayFabIDsFromTwitchIDsRequest> OnGetPlayFabIDsFromTwitchIDsRequestEvent;
        public event PlayFabResultEvent<GetPlayFabIDsFromTwitchIDsResult> OnGetPlayFabIDsFromTwitchIDsResultEvent;
        public event PlayFabRequestEvent<LinkAndroidDeviceIDRequest> OnLinkAndroidDeviceIDRequestEvent;
        public event PlayFabResultEvent<LinkAndroidDeviceIDResult> OnLinkAndroidDeviceIDResultEvent;
        public event PlayFabRequestEvent<LinkCustomIDRequest> OnLinkCustomIDRequestEvent;
        public event PlayFabResultEvent<LinkCustomIDResult> OnLinkCustomIDResultEvent;
        public event PlayFabRequestEvent<LinkFacebookAccountRequest> OnLinkFacebookAccountRequestEvent;
        public event PlayFabResultEvent<LinkFacebookAccountResult> OnLinkFacebookAccountResultEvent;
        public event PlayFabRequestEvent<LinkGameCenterAccountRequest> OnLinkGameCenterAccountRequestEvent;
        public event PlayFabResultEvent<LinkGameCenterAccountResult> OnLinkGameCenterAccountResultEvent;
        public event PlayFabRequestEvent<LinkGoogleAccountRequest> OnLinkGoogleAccountRequestEvent;
        public event PlayFabResultEvent<LinkGoogleAccountResult> OnLinkGoogleAccountResultEvent;
        public event PlayFabRequestEvent<LinkIOSDeviceIDRequest> OnLinkIOSDeviceIDRequestEvent;
        public event PlayFabResultEvent<LinkIOSDeviceIDResult> OnLinkIOSDeviceIDResultEvent;
        public event PlayFabRequestEvent<LinkKongregateAccountRequest> OnLinkKongregateRequestEvent;
        public event PlayFabResultEvent<LinkKongregateAccountResult> OnLinkKongregateResultEvent;
        public event PlayFabRequestEvent<LinkSteamAccountRequest> OnLinkSteamAccountRequestEvent;
        public event PlayFabResultEvent<LinkSteamAccountResult> OnLinkSteamAccountResultEvent;
        public event PlayFabRequestEvent<LinkTwitchAccountRequest> OnLinkTwitchRequestEvent;
        public event PlayFabResultEvent<LinkTwitchAccountResult> OnLinkTwitchResultEvent;
        public event PlayFabRequestEvent<LinkWindowsHelloAccountRequest> OnLinkWindowsHelloRequestEvent;
        public event PlayFabResultEvent<LinkWindowsHelloAccountResponse> OnLinkWindowsHelloResultEvent;
        public event PlayFabRequestEvent<RemoveGenericIDRequest> OnRemoveGenericIDRequestEvent;
        public event PlayFabResultEvent<RemoveGenericIDResult> OnRemoveGenericIDResultEvent;
        public event PlayFabRequestEvent<ReportPlayerClientRequest> OnReportPlayerRequestEvent;
        public event PlayFabResultEvent<ReportPlayerClientResult> OnReportPlayerResultEvent;
        public event PlayFabRequestEvent<SendAccountRecoveryEmailRequest> OnSendAccountRecoveryEmailRequestEvent;
        public event PlayFabResultEvent<SendAccountRecoveryEmailResult> OnSendAccountRecoveryEmailResultEvent;
        public event PlayFabRequestEvent<UnlinkAndroidDeviceIDRequest> OnUnlinkAndroidDeviceIDRequestEvent;
        public event PlayFabResultEvent<UnlinkAndroidDeviceIDResult> OnUnlinkAndroidDeviceIDResultEvent;
        public event PlayFabRequestEvent<UnlinkCustomIDRequest> OnUnlinkCustomIDRequestEvent;
        public event PlayFabResultEvent<UnlinkCustomIDResult> OnUnlinkCustomIDResultEvent;
        public event PlayFabRequestEvent<UnlinkFacebookAccountRequest> OnUnlinkFacebookAccountRequestEvent;
        public event PlayFabResultEvent<UnlinkFacebookAccountResult> OnUnlinkFacebookAccountResultEvent;
        public event PlayFabRequestEvent<UnlinkGameCenterAccountRequest> OnUnlinkGameCenterAccountRequestEvent;
        public event PlayFabResultEvent<UnlinkGameCenterAccountResult> OnUnlinkGameCenterAccountResultEvent;
        public event PlayFabRequestEvent<UnlinkGoogleAccountRequest> OnUnlinkGoogleAccountRequestEvent;
        public event PlayFabResultEvent<UnlinkGoogleAccountResult> OnUnlinkGoogleAccountResultEvent;
        public event PlayFabRequestEvent<UnlinkIOSDeviceIDRequest> OnUnlinkIOSDeviceIDRequestEvent;
        public event PlayFabResultEvent<UnlinkIOSDeviceIDResult> OnUnlinkIOSDeviceIDResultEvent;
        public event PlayFabRequestEvent<UnlinkKongregateAccountRequest> OnUnlinkKongregateRequestEvent;
        public event PlayFabResultEvent<UnlinkKongregateAccountResult> OnUnlinkKongregateResultEvent;
        public event PlayFabRequestEvent<UnlinkSteamAccountRequest> OnUnlinkSteamAccountRequestEvent;
        public event PlayFabResultEvent<UnlinkSteamAccountResult> OnUnlinkSteamAccountResultEvent;
        public event PlayFabRequestEvent<UnlinkTwitchAccountRequest> OnUnlinkTwitchRequestEvent;
        public event PlayFabResultEvent<UnlinkTwitchAccountResult> OnUnlinkTwitchResultEvent;
        public event PlayFabRequestEvent<UnlinkWindowsHelloAccountRequest> OnUnlinkWindowsHelloRequestEvent;
        public event PlayFabResultEvent<UnlinkWindowsHelloAccountResponse> OnUnlinkWindowsHelloResultEvent;
        public event PlayFabRequestEvent<UpdateAvatarUrlRequest> OnUpdateAvatarUrlRequestEvent;
        public event PlayFabResultEvent<EmptyResult> OnUpdateAvatarUrlResultEvent;
        public event PlayFabRequestEvent<UpdateUserTitleDisplayNameRequest> OnUpdateUserTitleDisplayNameRequestEvent;
        public event PlayFabResultEvent<UpdateUserTitleDisplayNameResult> OnUpdateUserTitleDisplayNameResultEvent;
        public event PlayFabRequestEvent<GetFriendLeaderboardRequest> OnGetFriendLeaderboardRequestEvent;
        public event PlayFabResultEvent<GetLeaderboardResult> OnGetFriendLeaderboardResultEvent;
        public event PlayFabRequestEvent<GetFriendLeaderboardAroundPlayerRequest> OnGetFriendLeaderboardAroundPlayerRequestEvent;
        public event PlayFabResultEvent<GetFriendLeaderboardAroundPlayerResult> OnGetFriendLeaderboardAroundPlayerResultEvent;
        public event PlayFabRequestEvent<GetLeaderboardRequest> OnGetLeaderboardRequestEvent;
        public event PlayFabResultEvent<GetLeaderboardResult> OnGetLeaderboardResultEvent;
        public event PlayFabRequestEvent<GetLeaderboardAroundPlayerRequest> OnGetLeaderboardAroundPlayerRequestEvent;
        public event PlayFabResultEvent<GetLeaderboardAroundPlayerResult> OnGetLeaderboardAroundPlayerResultEvent;
        public event PlayFabRequestEvent<GetPlayerStatisticsRequest> OnGetPlayerStatisticsRequestEvent;
        public event PlayFabResultEvent<GetPlayerStatisticsResult> OnGetPlayerStatisticsResultEvent;
        public event PlayFabRequestEvent<GetPlayerStatisticVersionsRequest> OnGetPlayerStatisticVersionsRequestEvent;
        public event PlayFabResultEvent<GetPlayerStatisticVersionsResult> OnGetPlayerStatisticVersionsResultEvent;
        public event PlayFabRequestEvent<GetUserDataRequest> OnGetUserDataRequestEvent;
        public event PlayFabResultEvent<GetUserDataResult> OnGetUserDataResultEvent;
        public event PlayFabRequestEvent<GetUserDataRequest> OnGetUserPublisherDataRequestEvent;
        public event PlayFabResultEvent<GetUserDataResult> OnGetUserPublisherDataResultEvent;
        public event PlayFabRequestEvent<GetUserDataRequest> OnGetUserPublisherReadOnlyDataRequestEvent;
        public event PlayFabResultEvent<GetUserDataResult> OnGetUserPublisherReadOnlyDataResultEvent;
        public event PlayFabRequestEvent<GetUserDataRequest> OnGetUserReadOnlyDataRequestEvent;
        public event PlayFabResultEvent<GetUserDataResult> OnGetUserReadOnlyDataResultEvent;
        public event PlayFabRequestEvent<UpdatePlayerStatisticsRequest> OnUpdatePlayerStatisticsRequestEvent;
        public event PlayFabResultEvent<UpdatePlayerStatisticsResult> OnUpdatePlayerStatisticsResultEvent;
        public event PlayFabRequestEvent<UpdateUserDataRequest> OnUpdateUserDataRequestEvent;
        public event PlayFabResultEvent<UpdateUserDataResult> OnUpdateUserDataResultEvent;
        public event PlayFabRequestEvent<UpdateUserDataRequest> OnUpdateUserPublisherDataRequestEvent;
        public event PlayFabResultEvent<UpdateUserDataResult> OnUpdateUserPublisherDataResultEvent;
        public event PlayFabRequestEvent<GetCatalogItemsRequest> OnGetCatalogItemsRequestEvent;
        public event PlayFabResultEvent<GetCatalogItemsResult> OnGetCatalogItemsResultEvent;
        public event PlayFabRequestEvent<GetPublisherDataRequest> OnGetPublisherDataRequestEvent;
        public event PlayFabResultEvent<GetPublisherDataResult> OnGetPublisherDataResultEvent;
        public event PlayFabRequestEvent<GetStoreItemsRequest> OnGetStoreItemsRequestEvent;
        public event PlayFabResultEvent<GetStoreItemsResult> OnGetStoreItemsResultEvent;
        public event PlayFabRequestEvent<GetTimeRequest> OnGetTimeRequestEvent;
        public event PlayFabResultEvent<GetTimeResult> OnGetTimeResultEvent;
        public event PlayFabRequestEvent<GetTitleDataRequest> OnGetTitleDataRequestEvent;
        public event PlayFabResultEvent<GetTitleDataResult> OnGetTitleDataResultEvent;
        public event PlayFabRequestEvent<GetTitleNewsRequest> OnGetTitleNewsRequestEvent;
        public event PlayFabResultEvent<GetTitleNewsResult> OnGetTitleNewsResultEvent;
        public event PlayFabRequestEvent<AddUserVirtualCurrencyRequest> OnAddUserVirtualCurrencyRequestEvent;
        public event PlayFabResultEvent<ModifyUserVirtualCurrencyResult> OnAddUserVirtualCurrencyResultEvent;
        public event PlayFabRequestEvent<ConfirmPurchaseRequest> OnConfirmPurchaseRequestEvent;
        public event PlayFabResultEvent<ConfirmPurchaseResult> OnConfirmPurchaseResultEvent;
        public event PlayFabRequestEvent<ConsumeItemRequest> OnConsumeItemRequestEvent;
        public event PlayFabResultEvent<ConsumeItemResult> OnConsumeItemResultEvent;
        public event PlayFabRequestEvent<GetCharacterInventoryRequest> OnGetCharacterInventoryRequestEvent;
        public event PlayFabResultEvent<GetCharacterInventoryResult> OnGetCharacterInventoryResultEvent;
        public event PlayFabRequestEvent<GetPurchaseRequest> OnGetPurchaseRequestEvent;
        public event PlayFabResultEvent<GetPurchaseResult> OnGetPurchaseResultEvent;
        public event PlayFabRequestEvent<GetUserInventoryRequest> OnGetUserInventoryRequestEvent;
        public event PlayFabResultEvent<GetUserInventoryResult> OnGetUserInventoryResultEvent;
        public event PlayFabRequestEvent<PayForPurchaseRequest> OnPayForPurchaseRequestEvent;
        public event PlayFabResultEvent<PayForPurchaseResult> OnPayForPurchaseResultEvent;
        public event PlayFabRequestEvent<PurchaseItemRequest> OnPurchaseItemRequestEvent;
        public event PlayFabResultEvent<PurchaseItemResult> OnPurchaseItemResultEvent;
        public event PlayFabRequestEvent<RedeemCouponRequest> OnRedeemCouponRequestEvent;
        public event PlayFabResultEvent<RedeemCouponResult> OnRedeemCouponResultEvent;
        public event PlayFabRequestEvent<StartPurchaseRequest> OnStartPurchaseRequestEvent;
        public event PlayFabResultEvent<StartPurchaseResult> OnStartPurchaseResultEvent;
        public event PlayFabRequestEvent<SubtractUserVirtualCurrencyRequest> OnSubtractUserVirtualCurrencyRequestEvent;
        public event PlayFabResultEvent<ModifyUserVirtualCurrencyResult> OnSubtractUserVirtualCurrencyResultEvent;
        public event PlayFabRequestEvent<UnlockContainerInstanceRequest> OnUnlockContainerInstanceRequestEvent;
        public event PlayFabResultEvent<UnlockContainerItemResult> OnUnlockContainerInstanceResultEvent;
        public event PlayFabRequestEvent<UnlockContainerItemRequest> OnUnlockContainerItemRequestEvent;
        public event PlayFabResultEvent<UnlockContainerItemResult> OnUnlockContainerItemResultEvent;
        public event PlayFabRequestEvent<AddFriendRequest> OnAddFriendRequestEvent;
        public event PlayFabResultEvent<AddFriendResult> OnAddFriendResultEvent;
        public event PlayFabRequestEvent<GetFriendsListRequest> OnGetFriendsListRequestEvent;
        public event PlayFabResultEvent<GetFriendsListResult> OnGetFriendsListResultEvent;
        public event PlayFabRequestEvent<RemoveFriendRequest> OnRemoveFriendRequestEvent;
        public event PlayFabResultEvent<RemoveFriendResult> OnRemoveFriendResultEvent;
        public event PlayFabRequestEvent<SetFriendTagsRequest> OnSetFriendTagsRequestEvent;
        public event PlayFabResultEvent<SetFriendTagsResult> OnSetFriendTagsResultEvent;
        public event PlayFabRequestEvent<RegisterForIOSPushNotificationRequest> OnRegisterForIOSPushNotificationRequestEvent;
        public event PlayFabResultEvent<RegisterForIOSPushNotificationResult> OnRegisterForIOSPushNotificationResultEvent;
        public event PlayFabRequestEvent<RestoreIOSPurchasesRequest> OnRestoreIOSPurchasesRequestEvent;
        public event PlayFabResultEvent<RestoreIOSPurchasesResult> OnRestoreIOSPurchasesResultEvent;
        public event PlayFabRequestEvent<ValidateIOSReceiptRequest> OnValidateIOSReceiptRequestEvent;
        public event PlayFabResultEvent<ValidateIOSReceiptResult> OnValidateIOSReceiptResultEvent;
        public event PlayFabRequestEvent<CurrentGamesRequest> OnGetCurrentGamesRequestEvent;
        public event PlayFabResultEvent<CurrentGamesResult> OnGetCurrentGamesResultEvent;
        public event PlayFabRequestEvent<GameServerRegionsRequest> OnGetGameServerRegionsRequestEvent;
        public event PlayFabResultEvent<GameServerRegionsResult> OnGetGameServerRegionsResultEvent;
        public event PlayFabRequestEvent<MatchmakeRequest> OnMatchmakeRequestEvent;
        public event PlayFabResultEvent<MatchmakeResult> OnMatchmakeResultEvent;
        public event PlayFabRequestEvent<StartGameRequest> OnStartGameRequestEvent;
        public event PlayFabResultEvent<StartGameResult> OnStartGameResultEvent;
        public event PlayFabRequestEvent<AndroidDevicePushNotificationRegistrationRequest> OnAndroidDevicePushNotificationRegistrationRequestEvent;
        public event PlayFabResultEvent<AndroidDevicePushNotificationRegistrationResult> OnAndroidDevicePushNotificationRegistrationResultEvent;
        public event PlayFabRequestEvent<ValidateGooglePlayPurchaseRequest> OnValidateGooglePlayPurchaseRequestEvent;
        public event PlayFabResultEvent<ValidateGooglePlayPurchaseResult> OnValidateGooglePlayPurchaseResultEvent;
        public event PlayFabRequestEvent<WriteClientCharacterEventRequest> OnWriteCharacterEventRequestEvent;
        public event PlayFabResultEvent<WriteEventResponse> OnWriteCharacterEventResultEvent;
        public event PlayFabRequestEvent<WriteClientPlayerEventRequest> OnWritePlayerEventRequestEvent;
        public event PlayFabResultEvent<WriteEventResponse> OnWritePlayerEventResultEvent;
        public event PlayFabRequestEvent<WriteTitleEventRequest> OnWriteTitleEventRequestEvent;
        public event PlayFabResultEvent<WriteEventResponse> OnWriteTitleEventResultEvent;
        public event PlayFabRequestEvent<AddSharedGroupMembersRequest> OnAddSharedGroupMembersRequestEvent;
        public event PlayFabResultEvent<AddSharedGroupMembersResult> OnAddSharedGroupMembersResultEvent;
        public event PlayFabRequestEvent<CreateSharedGroupRequest> OnCreateSharedGroupRequestEvent;
        public event PlayFabResultEvent<CreateSharedGroupResult> OnCreateSharedGroupResultEvent;
        public event PlayFabRequestEvent<GetSharedGroupDataRequest> OnGetSharedGroupDataRequestEvent;
        public event PlayFabResultEvent<GetSharedGroupDataResult> OnGetSharedGroupDataResultEvent;
        public event PlayFabRequestEvent<RemoveSharedGroupMembersRequest> OnRemoveSharedGroupMembersRequestEvent;
        public event PlayFabResultEvent<RemoveSharedGroupMembersResult> OnRemoveSharedGroupMembersResultEvent;
        public event PlayFabRequestEvent<UpdateSharedGroupDataRequest> OnUpdateSharedGroupDataRequestEvent;
        public event PlayFabResultEvent<UpdateSharedGroupDataResult> OnUpdateSharedGroupDataResultEvent;
        public event PlayFabRequestEvent<ExecuteCloudScriptRequest> OnExecuteCloudScriptRequestEvent;
        public event PlayFabResultEvent<ExecuteCloudScriptResult> OnExecuteCloudScriptResultEvent;
        public event PlayFabRequestEvent<GetContentDownloadUrlRequest> OnGetContentDownloadUrlRequestEvent;
        public event PlayFabResultEvent<GetContentDownloadUrlResult> OnGetContentDownloadUrlResultEvent;
        public event PlayFabRequestEvent<ListUsersCharactersRequest> OnGetAllUsersCharactersRequestEvent;
        public event PlayFabResultEvent<ListUsersCharactersResult> OnGetAllUsersCharactersResultEvent;
        public event PlayFabRequestEvent<GetCharacterLeaderboardRequest> OnGetCharacterLeaderboardRequestEvent;
        public event PlayFabResultEvent<GetCharacterLeaderboardResult> OnGetCharacterLeaderboardResultEvent;
        public event PlayFabRequestEvent<GetCharacterStatisticsRequest> OnGetCharacterStatisticsRequestEvent;
        public event PlayFabResultEvent<GetCharacterStatisticsResult> OnGetCharacterStatisticsResultEvent;
        public event PlayFabRequestEvent<GetLeaderboardAroundCharacterRequest> OnGetLeaderboardAroundCharacterRequestEvent;
        public event PlayFabResultEvent<GetLeaderboardAroundCharacterResult> OnGetLeaderboardAroundCharacterResultEvent;
        public event PlayFabRequestEvent<GetLeaderboardForUsersCharactersRequest> OnGetLeaderboardForUserCharactersRequestEvent;
        public event PlayFabResultEvent<GetLeaderboardForUsersCharactersResult> OnGetLeaderboardForUserCharactersResultEvent;
        public event PlayFabRequestEvent<GrantCharacterToUserRequest> OnGrantCharacterToUserRequestEvent;
        public event PlayFabResultEvent<GrantCharacterToUserResult> OnGrantCharacterToUserResultEvent;
        public event PlayFabRequestEvent<UpdateCharacterStatisticsRequest> OnUpdateCharacterStatisticsRequestEvent;
        public event PlayFabResultEvent<UpdateCharacterStatisticsResult> OnUpdateCharacterStatisticsResultEvent;
        public event PlayFabRequestEvent<GetCharacterDataRequest> OnGetCharacterDataRequestEvent;
        public event PlayFabResultEvent<GetCharacterDataResult> OnGetCharacterDataResultEvent;
        public event PlayFabRequestEvent<GetCharacterDataRequest> OnGetCharacterReadOnlyDataRequestEvent;
        public event PlayFabResultEvent<GetCharacterDataResult> OnGetCharacterReadOnlyDataResultEvent;
        public event PlayFabRequestEvent<UpdateCharacterDataRequest> OnUpdateCharacterDataRequestEvent;
        public event PlayFabResultEvent<UpdateCharacterDataResult> OnUpdateCharacterDataResultEvent;
        public event PlayFabRequestEvent<ValidateAmazonReceiptRequest> OnValidateAmazonIAPReceiptRequestEvent;
        public event PlayFabResultEvent<ValidateAmazonReceiptResult> OnValidateAmazonIAPReceiptResultEvent;
        public event PlayFabRequestEvent<AcceptTradeRequest> OnAcceptTradeRequestEvent;
        public event PlayFabResultEvent<AcceptTradeResponse> OnAcceptTradeResultEvent;
        public event PlayFabRequestEvent<CancelTradeRequest> OnCancelTradeRequestEvent;
        public event PlayFabResultEvent<CancelTradeResponse> OnCancelTradeResultEvent;
        public event PlayFabRequestEvent<GetPlayerTradesRequest> OnGetPlayerTradesRequestEvent;
        public event PlayFabResultEvent<GetPlayerTradesResponse> OnGetPlayerTradesResultEvent;
        public event PlayFabRequestEvent<GetTradeStatusRequest> OnGetTradeStatusRequestEvent;
        public event PlayFabResultEvent<GetTradeStatusResponse> OnGetTradeStatusResultEvent;
        public event PlayFabRequestEvent<OpenTradeRequest> OnOpenTradeRequestEvent;
        public event PlayFabResultEvent<OpenTradeResponse> OnOpenTradeResultEvent;
        public event PlayFabRequestEvent<AttributeInstallRequest> OnAttributeInstallRequestEvent;
        public event PlayFabResultEvent<AttributeInstallResult> OnAttributeInstallResultEvent;
        public event PlayFabRequestEvent<GetPlayerSegmentsRequest> OnGetPlayerSegmentsRequestEvent;
        public event PlayFabResultEvent<GetPlayerSegmentsResult> OnGetPlayerSegmentsResultEvent;
        public event PlayFabRequestEvent<GetPlayerTagsRequest> OnGetPlayerTagsRequestEvent;
        public event PlayFabResultEvent<GetPlayerTagsResult> OnGetPlayerTagsResultEvent;
        public event PlayFabRequestEvent<ValidateWindowsReceiptRequest> OnValidateWindowsStoreReceiptRequestEvent;
        public event PlayFabResultEvent<ValidateWindowsReceiptResult> OnValidateWindowsStoreReceiptResultEvent;
    }
}
#endif
