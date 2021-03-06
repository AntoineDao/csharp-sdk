# PollinationSDK.Api.ArtifactsApi

All URIs are relative to *http://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateArtifact**](ArtifactsApi.md#createartifact) | **POST** /projects/{owner}/{name}/artifacts | Get an Artifact upload link.
[**DeleteArtifact**](ArtifactsApi.md#deleteartifact) | **DELETE** /projects/{owner}/{name}/artifacts | Delete one or many artifacts by key/prefix
[**ListArtifacts**](ArtifactsApi.md#listartifacts) | **GET** /projects/{owner}/{name}/artifacts | List artifacts in a project folder



## CreateArtifact

> S3UploadRequest CreateArtifact (string owner, string name, KeyRequest keyRequest)

Get an Artifact upload link.

Create a new artifact.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using PollinationSDK.Api;
using PollinationSDK.Client;
using PollinationSDK.Model;

namespace Example
{
    public class CreateArtifactExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure OAuth2 access token for authorization: Compulsory Auth
            Configuration.Default.AccessToken = "YOUR_JWT_TOKEN";

            var apiInstance = new ArtifactsApi(Configuration.Default);
            var owner = owner_example;  // string | 
            var name = name_example;  // string | 
            var keyRequest = new KeyRequest(); // KeyRequest | 

            try
            {
                // Get an Artifact upload link.
                S3UploadRequest result = apiInstance.CreateArtifact(owner, name, keyRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ArtifactsApi.CreateArtifact: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **owner** | **string**|  | 
 **name** | **string**|  | 
 **keyRequest** | [**KeyRequest**](KeyRequest.md)|  | 

### Return type

[**S3UploadRequest**](S3UploadRequest.md)

### Authorization

[Compulsory Auth](../README.md#Compulsory Auth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful Response |  -  |
| **422** | Validation Error |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## DeleteArtifact

> UpdateAccepted DeleteArtifact (string owner, string name, List<string> path = null)

Delete one or many artifacts by key/prefix

Delete one or multiple artifacts based on key prefix

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using PollinationSDK.Api;
using PollinationSDK.Client;
using PollinationSDK.Model;

namespace Example
{
    public class DeleteArtifactExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure OAuth2 access token for authorization: Compulsory Auth
            Configuration.Default.AccessToken = "YOUR_JWT_TOKEN";

            var apiInstance = new ArtifactsApi(Configuration.Default);
            var owner = owner_example;  // string | 
            var name = name_example;  // string | 
            var path = new List<string>(); // List<string> | The path to an artifact within a project folder (optional) 

            try
            {
                // Delete one or many artifacts by key/prefix
                UpdateAccepted result = apiInstance.DeleteArtifact(owner, name, path);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ArtifactsApi.DeleteArtifact: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **owner** | **string**|  | 
 **name** | **string**|  | 
 **path** | [**List&lt;string&gt;**](string.md)| The path to an artifact within a project folder | [optional] 

### Return type

[**UpdateAccepted**](UpdateAccepted.md)

### Authorization

[Compulsory Auth](../README.md#Compulsory Auth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **202** | Successful Response |  -  |
| **422** | Validation Error |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## ListArtifacts

> List&lt;FileMeta&gt; ListArtifacts (string owner, string name, int page = null, int perPage = null, List<string> path = null)

List artifacts in a project folder

Retrieve a list of artifacts.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using PollinationSDK.Api;
using PollinationSDK.Client;
using PollinationSDK.Model;

namespace Example
{
    public class ListArtifactsExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            // Configure OAuth2 access token for authorization: Optional Auth
            Configuration.Default.AccessToken = "YOUR_JWT_TOKEN";

            var apiInstance = new ArtifactsApi(Configuration.Default);
            var owner = owner_example;  // string | 
            var name = name_example;  // string | 
            var page = 56;  // int | Page number starting from 1 (optional)  (default to 1)
            var perPage = 56;  // int | Number of items per page (optional)  (default to 25)
            var path = new List<string>(); // List<string> | The path to an artifact within a project folder (optional) 

            try
            {
                // List artifacts in a project folder
                List<FileMeta> result = apiInstance.ListArtifacts(owner, name, page, perPage, path);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ArtifactsApi.ListArtifacts: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **owner** | **string**|  | 
 **name** | **string**|  | 
 **page** | **int**| Page number starting from 1 | [optional] [default to 1]
 **perPage** | **int**| Number of items per page | [optional] [default to 25]
 **path** | [**List&lt;string&gt;**](string.md)| The path to an artifact within a project folder | [optional] 

### Return type

[**List&lt;FileMeta&gt;**](FileMeta.md)

### Authorization

[Optional Auth](../README.md#Optional Auth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Retrieved |  -  |
| **422** | Validation Error |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)

