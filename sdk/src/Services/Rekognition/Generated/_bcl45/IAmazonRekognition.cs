/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

/*
 * Do not modify this file. This file is generated from the rekognition-2016-06-27.normal.json service model.
 */


using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.Rekognition.Model;

namespace Amazon.Rekognition
{
    /// <summary>
    /// Interface for accessing Rekognition
    ///
    /// This is the Amazon Rekognition API reference.
    /// </summary>
    public partial interface IAmazonRekognition : IAmazonService, IDisposable
    {

        
        #region  CompareFaces


        /// <summary>
        /// Compares a face in the <i>source</i> input image with each of the 100 largest faces
        /// detected in the <i>target</i> input image. 
        /// 
        ///  <note> 
        /// <para>
        ///  If the source image contains multiple faces, the service detects the largest face
        /// and compares it with each face detected in the target image. 
        /// </para>
        ///  </note> 
        /// <para>
        /// You pass the input and target images either as base64-encoded image bytes or as references
        /// to images in an Amazon S3 bucket. If you use the AWS CLI to call Amazon Rekognition
        /// operations, passing image bytes isn't supported. The image must be formatted as a
        /// PNG or JPEG file. 
        /// </para>
        ///  
        /// <para>
        /// In response, the operation returns an array of face matches ordered by similarity
        /// score in descending order. For each face match, the response provides a bounding box
        /// of the face, facial landmarks, pose details (pitch, role, and yaw), quality (brightness
        /// and sharpness), and confidence value (indicating the level of confidence that the
        /// bounding box contains a face). The response also provides a similarity score, which
        /// indicates how closely the faces match. 
        /// </para>
        ///  <note> 
        /// <para>
        /// By default, only faces with a similarity score of greater than or equal to 80% are
        /// returned in the response. You can change this value by specifying the <code>SimilarityThreshold</code>
        /// parameter.
        /// </para>
        ///  </note> 
        /// <para>
        ///  <code>CompareFaces</code> also returns an array of faces that don't match the source
        /// image. For each face, it returns a bounding box, confidence value, landmarks, pose
        /// details, and quality. The response also returns information about the face in the
        /// source image, including the bounding box of the face and confidence value.
        /// </para>
        ///  
        /// <para>
        /// If the image doesn't contain Exif metadata, <code>CompareFaces</code> returns orientation
        /// information for the source and target images. Use these values to display the images
        /// with the correct image orientation.
        /// </para>
        ///  
        /// <para>
        /// If no faces are detected in the source or target images, <code>CompareFaces</code>
        /// returns an <code>InvalidParameterException</code> error. 
        /// </para>
        ///  <note> 
        /// <para>
        ///  This is a stateless API operation. That is, data returned by this operation doesn't
        /// persist.
        /// </para>
        ///  </note> 
        /// <para>
        /// For an example, see Comparing Faces in Images in the Amazon Rekognition Developer
        /// Guide.
        /// </para>
        ///  
        /// <para>
        /// This operation requires permissions to perform the <code>rekognition:CompareFaces</code>
        /// action.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CompareFaces service method.</param>
        /// 
        /// <returns>The response from the CompareFaces service method, as returned by Rekognition.</returns>
        /// <exception cref="Amazon.Rekognition.Model.AccessDeniedException">
        /// You are not authorized to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ImageTooLargeException">
        /// The input image size exceeds the allowed limit. For more information, see Limits in
        /// Amazon Rekognition in the Amazon Rekognition Developer Guide.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.InternalServerErrorException">
        /// Amazon Rekognition experienced a service issue. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.InvalidImageFormatException">
        /// The provided image format is not supported.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.InvalidParameterException">
        /// Input parameter violated a constraint. Validate your parameter before calling the
        /// API operation again.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.InvalidS3ObjectException">
        /// Amazon Rekognition is unable to access the S3 object specified in the request.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ProvisionedThroughputExceededException">
        /// The number of requests exceeded your throughput limit. If you want to increase this
        /// limit, contact Amazon Rekognition.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ThrottlingException">
        /// Amazon Rekognition is temporarily unable to process the request. Try your call again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rekognition-2016-06-27/CompareFaces">REST API Reference for CompareFaces Operation</seealso>
        CompareFacesResponse CompareFaces(CompareFacesRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the CompareFaces operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CompareFaces operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rekognition-2016-06-27/CompareFaces">REST API Reference for CompareFaces Operation</seealso>
        Task<CompareFacesResponse> CompareFacesAsync(CompareFacesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateCollection


        /// <summary>
        /// Creates a collection in an AWS Region. You can add faces to the collection using the
        /// operation. 
        /// 
        ///  
        /// <para>
        /// For example, you might create collections, one for each of your application users.
        /// A user can then index faces using the <code>IndexFaces</code> operation and persist
        /// results in a specific collection. Then, a user can search the collection for faces
        /// in the user-specific container. 
        /// </para>
        ///  
        /// <para>
        /// When you create a collection, it is associated with the latest version of the face
        /// model version.
        /// </para>
        ///  <note> 
        /// <para>
        /// Collection names are case-sensitive.
        /// </para>
        ///  </note> 
        /// <para>
        /// This operation requires permissions to perform the <code>rekognition:CreateCollection</code>
        /// action.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateCollection service method.</param>
        /// 
        /// <returns>The response from the CreateCollection service method, as returned by Rekognition.</returns>
        /// <exception cref="Amazon.Rekognition.Model.AccessDeniedException">
        /// You are not authorized to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.InternalServerErrorException">
        /// Amazon Rekognition experienced a service issue. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.InvalidParameterException">
        /// Input parameter violated a constraint. Validate your parameter before calling the
        /// API operation again.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ProvisionedThroughputExceededException">
        /// The number of requests exceeded your throughput limit. If you want to increase this
        /// limit, contact Amazon Rekognition.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ResourceAlreadyExistsException">
        /// A collection with the specified ID already exists.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ThrottlingException">
        /// Amazon Rekognition is temporarily unable to process the request. Try your call again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rekognition-2016-06-27/CreateCollection">REST API Reference for CreateCollection Operation</seealso>
        CreateCollectionResponse CreateCollection(CreateCollectionRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the CreateCollection operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateCollection operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rekognition-2016-06-27/CreateCollection">REST API Reference for CreateCollection Operation</seealso>
        Task<CreateCollectionResponse> CreateCollectionAsync(CreateCollectionRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateStreamProcessor


        /// <summary>
        /// Creates an Amazon Rekognition stream processor that you can use to detect and recognize
        /// faces in a streaming video.
        /// 
        ///  
        /// <para>
        /// Amazon Rekognition Video is a consumer of live video from Amazon Kinesis Video Streams.
        /// Amazon Rekognition Video sends analysis results to Amazon Kinesis Data Streams.
        /// </para>
        ///  
        /// <para>
        /// You provide as input a Kinesis video stream (<code>Input</code>) and a Kinesis data
        /// stream (<code>Output</code>) stream. You also specify the face recognition criteria
        /// in <code>Settings</code>. For example, the collection containing faces that you want
        /// to recognize. Use <code>Name</code> to assign an identifier for the stream processor.
        /// You use <code>Name</code> to manage the stream processor. For example, you can start
        /// processing the source video by calling with the <code>Name</code> field. 
        /// </para>
        ///  
        /// <para>
        /// After you have finished analyzing a streaming video, use to stop processing. You can
        /// delete the stream processor by calling .
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateStreamProcessor service method.</param>
        /// 
        /// <returns>The response from the CreateStreamProcessor service method, as returned by Rekognition.</returns>
        /// <exception cref="Amazon.Rekognition.Model.AccessDeniedException">
        /// You are not authorized to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.InternalServerErrorException">
        /// Amazon Rekognition experienced a service issue. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.InvalidParameterException">
        /// Input parameter violated a constraint. Validate your parameter before calling the
        /// API operation again.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.LimitExceededException">
        /// An Amazon Rekognition service limit was exceeded. For example, if you start too many
        /// Amazon Rekognition Video jobs concurrently, calls to start operations (<code>StartLabelDetection</code>,
        /// for example) will raise a <code>LimitExceededException</code> exception (HTTP status
        /// code: 400) until the number of concurrently running jobs is below the Amazon Rekognition
        /// service limit.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ProvisionedThroughputExceededException">
        /// The number of requests exceeded your throughput limit. If you want to increase this
        /// limit, contact Amazon Rekognition.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ResourceInUseException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ThrottlingException">
        /// Amazon Rekognition is temporarily unable to process the request. Try your call again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rekognition-2016-06-27/CreateStreamProcessor">REST API Reference for CreateStreamProcessor Operation</seealso>
        CreateStreamProcessorResponse CreateStreamProcessor(CreateStreamProcessorRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the CreateStreamProcessor operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateStreamProcessor operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rekognition-2016-06-27/CreateStreamProcessor">REST API Reference for CreateStreamProcessor Operation</seealso>
        Task<CreateStreamProcessorResponse> CreateStreamProcessorAsync(CreateStreamProcessorRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteCollection


        /// <summary>
        /// Deletes the specified collection. Note that this operation removes all faces in the
        /// collection. For an example, see <a>delete-collection-procedure</a>.
        /// 
        ///  
        /// <para>
        /// This operation requires permissions to perform the <code>rekognition:DeleteCollection</code>
        /// action.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteCollection service method.</param>
        /// 
        /// <returns>The response from the DeleteCollection service method, as returned by Rekognition.</returns>
        /// <exception cref="Amazon.Rekognition.Model.AccessDeniedException">
        /// You are not authorized to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.InternalServerErrorException">
        /// Amazon Rekognition experienced a service issue. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.InvalidParameterException">
        /// Input parameter violated a constraint. Validate your parameter before calling the
        /// API operation again.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ProvisionedThroughputExceededException">
        /// The number of requests exceeded your throughput limit. If you want to increase this
        /// limit, contact Amazon Rekognition.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ResourceNotFoundException">
        /// The collection specified in the request cannot be found.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ThrottlingException">
        /// Amazon Rekognition is temporarily unable to process the request. Try your call again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rekognition-2016-06-27/DeleteCollection">REST API Reference for DeleteCollection Operation</seealso>
        DeleteCollectionResponse DeleteCollection(DeleteCollectionRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteCollection operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteCollection operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rekognition-2016-06-27/DeleteCollection">REST API Reference for DeleteCollection Operation</seealso>
        Task<DeleteCollectionResponse> DeleteCollectionAsync(DeleteCollectionRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteFaces


        /// <summary>
        /// Deletes faces from a collection. You specify a collection ID and an array of face
        /// IDs to remove from the collection.
        /// 
        ///  
        /// <para>
        /// This operation requires permissions to perform the <code>rekognition:DeleteFaces</code>
        /// action.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteFaces service method.</param>
        /// 
        /// <returns>The response from the DeleteFaces service method, as returned by Rekognition.</returns>
        /// <exception cref="Amazon.Rekognition.Model.AccessDeniedException">
        /// You are not authorized to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.InternalServerErrorException">
        /// Amazon Rekognition experienced a service issue. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.InvalidParameterException">
        /// Input parameter violated a constraint. Validate your parameter before calling the
        /// API operation again.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ProvisionedThroughputExceededException">
        /// The number of requests exceeded your throughput limit. If you want to increase this
        /// limit, contact Amazon Rekognition.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ResourceNotFoundException">
        /// The collection specified in the request cannot be found.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ThrottlingException">
        /// Amazon Rekognition is temporarily unable to process the request. Try your call again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rekognition-2016-06-27/DeleteFaces">REST API Reference for DeleteFaces Operation</seealso>
        DeleteFacesResponse DeleteFaces(DeleteFacesRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteFaces operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteFaces operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rekognition-2016-06-27/DeleteFaces">REST API Reference for DeleteFaces Operation</seealso>
        Task<DeleteFacesResponse> DeleteFacesAsync(DeleteFacesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteStreamProcessor


        /// <summary>
        /// Deletes the stream processor identified by <code>Name</code>. You assign the value
        /// for <code>Name</code> when you create the stream processor with . You might not be
        /// able to use the same name for a stream processor for a few seconds after calling <code>DeleteStreamProcessor</code>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteStreamProcessor service method.</param>
        /// 
        /// <returns>The response from the DeleteStreamProcessor service method, as returned by Rekognition.</returns>
        /// <exception cref="Amazon.Rekognition.Model.AccessDeniedException">
        /// You are not authorized to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.InternalServerErrorException">
        /// Amazon Rekognition experienced a service issue. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.InvalidParameterException">
        /// Input parameter violated a constraint. Validate your parameter before calling the
        /// API operation again.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ProvisionedThroughputExceededException">
        /// The number of requests exceeded your throughput limit. If you want to increase this
        /// limit, contact Amazon Rekognition.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ResourceInUseException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ResourceNotFoundException">
        /// The collection specified in the request cannot be found.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ThrottlingException">
        /// Amazon Rekognition is temporarily unable to process the request. Try your call again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rekognition-2016-06-27/DeleteStreamProcessor">REST API Reference for DeleteStreamProcessor Operation</seealso>
        DeleteStreamProcessorResponse DeleteStreamProcessor(DeleteStreamProcessorRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteStreamProcessor operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteStreamProcessor operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rekognition-2016-06-27/DeleteStreamProcessor">REST API Reference for DeleteStreamProcessor Operation</seealso>
        Task<DeleteStreamProcessorResponse> DeleteStreamProcessorAsync(DeleteStreamProcessorRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeCollection


        /// <summary>
        /// Describes the specified collection. You can use <code>DescribeCollection</code> to
        /// get information, such as the number of faces indexed into a collection and the version
        /// of the model used by the collection for face detection.
        /// 
        ///  
        /// <para>
        /// For more information, see Describing a Collection in the Amazon Rekognition Developer
        /// Guide.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeCollection service method.</param>
        /// 
        /// <returns>The response from the DescribeCollection service method, as returned by Rekognition.</returns>
        /// <exception cref="Amazon.Rekognition.Model.AccessDeniedException">
        /// You are not authorized to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.InternalServerErrorException">
        /// Amazon Rekognition experienced a service issue. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.InvalidParameterException">
        /// Input parameter violated a constraint. Validate your parameter before calling the
        /// API operation again.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ProvisionedThroughputExceededException">
        /// The number of requests exceeded your throughput limit. If you want to increase this
        /// limit, contact Amazon Rekognition.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ResourceNotFoundException">
        /// The collection specified in the request cannot be found.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ThrottlingException">
        /// Amazon Rekognition is temporarily unable to process the request. Try your call again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rekognition-2016-06-27/DescribeCollection">REST API Reference for DescribeCollection Operation</seealso>
        DescribeCollectionResponse DescribeCollection(DescribeCollectionRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeCollection operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeCollection operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rekognition-2016-06-27/DescribeCollection">REST API Reference for DescribeCollection Operation</seealso>
        Task<DescribeCollectionResponse> DescribeCollectionAsync(DescribeCollectionRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeStreamProcessor


        /// <summary>
        /// Provides information about a stream processor created by . You can get information
        /// about the input and output streams, the input parameters for the face recognition
        /// being performed, and the current status of the stream processor.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeStreamProcessor service method.</param>
        /// 
        /// <returns>The response from the DescribeStreamProcessor service method, as returned by Rekognition.</returns>
        /// <exception cref="Amazon.Rekognition.Model.AccessDeniedException">
        /// You are not authorized to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.InternalServerErrorException">
        /// Amazon Rekognition experienced a service issue. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.InvalidParameterException">
        /// Input parameter violated a constraint. Validate your parameter before calling the
        /// API operation again.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ProvisionedThroughputExceededException">
        /// The number of requests exceeded your throughput limit. If you want to increase this
        /// limit, contact Amazon Rekognition.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ResourceNotFoundException">
        /// The collection specified in the request cannot be found.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ThrottlingException">
        /// Amazon Rekognition is temporarily unable to process the request. Try your call again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rekognition-2016-06-27/DescribeStreamProcessor">REST API Reference for DescribeStreamProcessor Operation</seealso>
        DescribeStreamProcessorResponse DescribeStreamProcessor(DescribeStreamProcessorRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeStreamProcessor operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeStreamProcessor operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rekognition-2016-06-27/DescribeStreamProcessor">REST API Reference for DescribeStreamProcessor Operation</seealso>
        Task<DescribeStreamProcessorResponse> DescribeStreamProcessorAsync(DescribeStreamProcessorRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DetectFaces


        /// <summary>
        /// Detects faces within an image that is provided as input.
        /// 
        ///  
        /// <para>
        ///  <code>DetectFaces</code> detects the 100 largest faces in the image. For each face
        /// detected, the operation returns face details. These details include a bounding box
        /// of the face, a confidence value (that the bounding box contains a face), and a fixed
        /// set of attributes such as facial landmarks (for example, coordinates of eye and mouth),
        /// gender, presence of beard, sunglasses, and so on. 
        /// </para>
        ///  
        /// <para>
        /// The face-detection algorithm is most effective on frontal faces. For non-frontal or
        /// obscured faces, the algorithm might not detect the faces or might detect faces with
        /// lower confidence. 
        /// </para>
        ///  
        /// <para>
        /// You pass the input image either as base64-encoded image bytes or as a reference to
        /// an image in an Amazon S3 bucket. If you use the to call Amazon Rekognition operations,
        /// passing image bytes is not supported. The image must be either a PNG or JPEG formatted
        /// file. 
        /// </para>
        ///  <note> 
        /// <para>
        /// This is a stateless API operation. That is, the operation does not persist any data.
        /// </para>
        ///  </note> 
        /// <para>
        /// This operation requires permissions to perform the <code>rekognition:DetectFaces</code>
        /// action. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DetectFaces service method.</param>
        /// 
        /// <returns>The response from the DetectFaces service method, as returned by Rekognition.</returns>
        /// <exception cref="Amazon.Rekognition.Model.AccessDeniedException">
        /// You are not authorized to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ImageTooLargeException">
        /// The input image size exceeds the allowed limit. For more information, see Limits in
        /// Amazon Rekognition in the Amazon Rekognition Developer Guide.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.InternalServerErrorException">
        /// Amazon Rekognition experienced a service issue. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.InvalidImageFormatException">
        /// The provided image format is not supported.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.InvalidParameterException">
        /// Input parameter violated a constraint. Validate your parameter before calling the
        /// API operation again.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.InvalidS3ObjectException">
        /// Amazon Rekognition is unable to access the S3 object specified in the request.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ProvisionedThroughputExceededException">
        /// The number of requests exceeded your throughput limit. If you want to increase this
        /// limit, contact Amazon Rekognition.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ThrottlingException">
        /// Amazon Rekognition is temporarily unable to process the request. Try your call again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rekognition-2016-06-27/DetectFaces">REST API Reference for DetectFaces Operation</seealso>
        DetectFacesResponse DetectFaces(DetectFacesRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the DetectFaces operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DetectFaces operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rekognition-2016-06-27/DetectFaces">REST API Reference for DetectFaces Operation</seealso>
        Task<DetectFacesResponse> DetectFacesAsync(DetectFacesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DetectLabels


        /// <summary>
        /// Detects instances of real-world entities within an image (JPEG or PNG) provided as
        /// input. This includes objects like flower, tree, and table; events like wedding, graduation,
        /// and birthday party; and concepts like landscape, evening, and nature. 
        /// 
        ///  
        /// <para>
        /// For an example, see Analyzing Images Stored in an Amazon S3 Bucket in the Amazon Rekognition
        /// Developer Guide.
        /// </para>
        ///  <note> 
        /// <para>
        ///  <code>DetectLabels</code> does not support the detection of activities. However,
        /// activity detection is supported for label detection in videos. For more information,
        /// see StartLabelDetection in the Amazon Rekognition Developer Guide.
        /// </para>
        ///  </note> 
        /// <para>
        /// You pass the input image as base64-encoded image bytes or as a reference to an image
        /// in an Amazon S3 bucket. If you use the AWS CLI to call Amazon Rekognition operations,
        /// passing image bytes is not supported. The image must be either a PNG or JPEG formatted
        /// file. 
        /// </para>
        ///  
        /// <para>
        ///  For each object, scene, and concept the API returns one or more labels. Each label
        /// provides the object name, and the level of confidence that the image contains the
        /// object. For example, suppose the input image has a lighthouse, the sea, and a rock.
        /// The response includes all three labels, one for each object. 
        /// </para>
        ///  
        /// <para>
        ///  <code>{Name: lighthouse, Confidence: 98.4629}</code> 
        /// </para>
        ///  
        /// <para>
        ///  <code>{Name: rock,Confidence: 79.2097}</code> 
        /// </para>
        ///  
        /// <para>
        ///  <code> {Name: sea,Confidence: 75.061}</code> 
        /// </para>
        ///  
        /// <para>
        /// In the preceding example, the operation returns one label for each of the three objects.
        /// The operation can also return multiple labels for the same object in the image. For
        /// example, if the input image shows a flower (for example, a tulip), the operation might
        /// return the following three labels. 
        /// </para>
        ///  
        /// <para>
        ///  <code>{Name: flower,Confidence: 99.0562}</code> 
        /// </para>
        ///  
        /// <para>
        ///  <code>{Name: plant,Confidence: 99.0562}</code> 
        /// </para>
        ///  
        /// <para>
        ///  <code>{Name: tulip,Confidence: 99.0562}</code> 
        /// </para>
        ///  
        /// <para>
        /// In this example, the detection algorithm more precisely identifies the flower as a
        /// tulip.
        /// </para>
        ///  
        /// <para>
        /// In response, the API returns an array of labels. In addition, the response also includes
        /// the orientation correction. Optionally, you can specify <code>MinConfidence</code>
        /// to control the confidence threshold for the labels returned. The default is 50%. You
        /// can also add the <code>MaxLabels</code> parameter to limit the number of labels returned.
        /// 
        /// </para>
        ///  <note> 
        /// <para>
        /// If the object detected is a person, the operation doesn't provide the same facial
        /// details that the <a>DetectFaces</a> operation provides.
        /// </para>
        ///  </note> 
        /// <para>
        ///  <code>DetectLabels</code> returns bounding boxes for instances of common object labels
        /// in an array of objects. An <code>Instance</code> object contains a object, for the
        /// location of the label on the image. It also includes the confidence by which the bounding
        /// box was detected.
        /// </para>
        ///  
        /// <para>
        ///  <code>DetectLabels</code> also returns a hierarchical taxonomy of detected labels.
        /// For example, a detected car might be assigned the label <i>car</i>. The label <i>car</i>
        /// has two parent labels: <i>Vehicle</i> (its parent) and <i>Transportation</i> (its
        /// grandparent). The response returns the entire list of ancestors for a label. Each
        /// ancestor is a unique label in the response. In the previous example, <i>Car</i>, <i>Vehicle</i>,
        /// and <i>Transportation</i> are returned as unique labels in the response. 
        /// </para>
        ///  
        /// <para>
        /// This is a stateless API operation. That is, the operation does not persist any data.
        /// </para>
        ///  
        /// <para>
        /// This operation requires permissions to perform the <code>rekognition:DetectLabels</code>
        /// action. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DetectLabels service method.</param>
        /// 
        /// <returns>The response from the DetectLabels service method, as returned by Rekognition.</returns>
        /// <exception cref="Amazon.Rekognition.Model.AccessDeniedException">
        /// You are not authorized to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ImageTooLargeException">
        /// The input image size exceeds the allowed limit. For more information, see Limits in
        /// Amazon Rekognition in the Amazon Rekognition Developer Guide.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.InternalServerErrorException">
        /// Amazon Rekognition experienced a service issue. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.InvalidImageFormatException">
        /// The provided image format is not supported.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.InvalidParameterException">
        /// Input parameter violated a constraint. Validate your parameter before calling the
        /// API operation again.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.InvalidS3ObjectException">
        /// Amazon Rekognition is unable to access the S3 object specified in the request.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ProvisionedThroughputExceededException">
        /// The number of requests exceeded your throughput limit. If you want to increase this
        /// limit, contact Amazon Rekognition.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ThrottlingException">
        /// Amazon Rekognition is temporarily unable to process the request. Try your call again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rekognition-2016-06-27/DetectLabels">REST API Reference for DetectLabels Operation</seealso>
        DetectLabelsResponse DetectLabels(DetectLabelsRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the DetectLabels operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DetectLabels operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rekognition-2016-06-27/DetectLabels">REST API Reference for DetectLabels Operation</seealso>
        Task<DetectLabelsResponse> DetectLabelsAsync(DetectLabelsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DetectModerationLabels


        /// <summary>
        /// Detects explicit or suggestive adult content in a specified JPEG or PNG format image.
        /// Use <code>DetectModerationLabels</code> to moderate images depending on your requirements.
        /// For example, you might want to filter images that contain nudity, but not images containing
        /// suggestive content.
        /// 
        ///  
        /// <para>
        /// To filter images, use the labels returned by <code>DetectModerationLabels</code> to
        /// determine which types of content are appropriate.
        /// </para>
        ///  
        /// <para>
        /// For information about moderation labels, see Detecting Unsafe Content in the Amazon
        /// Rekognition Developer Guide.
        /// </para>
        ///  
        /// <para>
        /// You pass the input image either as base64-encoded image bytes or as a reference to
        /// an image in an Amazon S3 bucket. If you use the AWS CLI to call Amazon Rekognition
        /// operations, passing image bytes is not supported. The image must be either a PNG or
        /// JPEG formatted file. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DetectModerationLabels service method.</param>
        /// 
        /// <returns>The response from the DetectModerationLabels service method, as returned by Rekognition.</returns>
        /// <exception cref="Amazon.Rekognition.Model.AccessDeniedException">
        /// You are not authorized to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ImageTooLargeException">
        /// The input image size exceeds the allowed limit. For more information, see Limits in
        /// Amazon Rekognition in the Amazon Rekognition Developer Guide.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.InternalServerErrorException">
        /// Amazon Rekognition experienced a service issue. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.InvalidImageFormatException">
        /// The provided image format is not supported.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.InvalidParameterException">
        /// Input parameter violated a constraint. Validate your parameter before calling the
        /// API operation again.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.InvalidS3ObjectException">
        /// Amazon Rekognition is unable to access the S3 object specified in the request.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ProvisionedThroughputExceededException">
        /// The number of requests exceeded your throughput limit. If you want to increase this
        /// limit, contact Amazon Rekognition.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ThrottlingException">
        /// Amazon Rekognition is temporarily unable to process the request. Try your call again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rekognition-2016-06-27/DetectModerationLabels">REST API Reference for DetectModerationLabels Operation</seealso>
        DetectModerationLabelsResponse DetectModerationLabels(DetectModerationLabelsRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the DetectModerationLabels operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DetectModerationLabels operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rekognition-2016-06-27/DetectModerationLabels">REST API Reference for DetectModerationLabels Operation</seealso>
        Task<DetectModerationLabelsResponse> DetectModerationLabelsAsync(DetectModerationLabelsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DetectText


        /// <summary>
        /// Detects text in the input image and converts it into machine-readable text.
        /// 
        ///  
        /// <para>
        /// Pass the input image as base64-encoded image bytes or as a reference to an image in
        /// an Amazon S3 bucket. If you use the AWS CLI to call Amazon Rekognition operations,
        /// you must pass it as a reference to an image in an Amazon S3 bucket. For the AWS CLI,
        /// passing image bytes is not supported. The image must be either a .png or .jpeg formatted
        /// file. 
        /// </para>
        ///  
        /// <para>
        /// The <code>DetectText</code> operation returns text in an array of elements, <code>TextDetections</code>.
        /// Each <code>TextDetection</code> element provides information about a single word or
        /// line of text that was detected in the image. 
        /// </para>
        ///  
        /// <para>
        /// A word is one or more ISO basic latin script characters that are not separated by
        /// spaces. <code>DetectText</code> can detect up to 50 words in an image.
        /// </para>
        ///  
        /// <para>
        /// A line is a string of equally spaced words. A line isn't necessarily a complete sentence.
        /// For example, a driver's license number is detected as a line. A line ends when there
        /// is no aligned text after it. Also, a line ends when there is a large gap between words,
        /// relative to the length of the words. This means, depending on the gap between words,
        /// Amazon Rekognition may detect multiple lines in text aligned in the same direction.
        /// Periods don't represent the end of a line. If a sentence spans multiple lines, the
        /// <code>DetectText</code> operation returns multiple lines.
        /// </para>
        ///  
        /// <para>
        /// To determine whether a <code>TextDetection</code> element is a line of text or a word,
        /// use the <code>TextDetection</code> object <code>Type</code> field. 
        /// </para>
        ///  
        /// <para>
        /// To be detected, text must be within +/- 90 degrees orientation of the horizontal axis.
        /// </para>
        ///  
        /// <para>
        /// For more information, see DetectText in the Amazon Rekognition Developer Guide.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DetectText service method.</param>
        /// 
        /// <returns>The response from the DetectText service method, as returned by Rekognition.</returns>
        /// <exception cref="Amazon.Rekognition.Model.AccessDeniedException">
        /// You are not authorized to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ImageTooLargeException">
        /// The input image size exceeds the allowed limit. For more information, see Limits in
        /// Amazon Rekognition in the Amazon Rekognition Developer Guide.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.InternalServerErrorException">
        /// Amazon Rekognition experienced a service issue. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.InvalidImageFormatException">
        /// The provided image format is not supported.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.InvalidParameterException">
        /// Input parameter violated a constraint. Validate your parameter before calling the
        /// API operation again.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.InvalidS3ObjectException">
        /// Amazon Rekognition is unable to access the S3 object specified in the request.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ProvisionedThroughputExceededException">
        /// The number of requests exceeded your throughput limit. If you want to increase this
        /// limit, contact Amazon Rekognition.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ThrottlingException">
        /// Amazon Rekognition is temporarily unable to process the request. Try your call again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rekognition-2016-06-27/DetectText">REST API Reference for DetectText Operation</seealso>
        DetectTextResponse DetectText(DetectTextRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the DetectText operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DetectText operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rekognition-2016-06-27/DetectText">REST API Reference for DetectText Operation</seealso>
        Task<DetectTextResponse> DetectTextAsync(DetectTextRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetCelebrityInfo


        /// <summary>
        /// Gets the name and additional information about a celebrity based on his or her Amazon
        /// Rekognition ID. The additional information is returned as an array of URLs. If there
        /// is no additional information about the celebrity, this list is empty.
        /// 
        ///  
        /// <para>
        /// For more information, see Recognizing Celebrities in an Image in the Amazon Rekognition
        /// Developer Guide.
        /// </para>
        ///  
        /// <para>
        /// This operation requires permissions to perform the <code>rekognition:GetCelebrityInfo</code>
        /// action. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCelebrityInfo service method.</param>
        /// 
        /// <returns>The response from the GetCelebrityInfo service method, as returned by Rekognition.</returns>
        /// <exception cref="Amazon.Rekognition.Model.AccessDeniedException">
        /// You are not authorized to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.InternalServerErrorException">
        /// Amazon Rekognition experienced a service issue. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.InvalidParameterException">
        /// Input parameter violated a constraint. Validate your parameter before calling the
        /// API operation again.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ProvisionedThroughputExceededException">
        /// The number of requests exceeded your throughput limit. If you want to increase this
        /// limit, contact Amazon Rekognition.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ResourceNotFoundException">
        /// The collection specified in the request cannot be found.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ThrottlingException">
        /// Amazon Rekognition is temporarily unable to process the request. Try your call again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rekognition-2016-06-27/GetCelebrityInfo">REST API Reference for GetCelebrityInfo Operation</seealso>
        GetCelebrityInfoResponse GetCelebrityInfo(GetCelebrityInfoRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the GetCelebrityInfo operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetCelebrityInfo operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rekognition-2016-06-27/GetCelebrityInfo">REST API Reference for GetCelebrityInfo Operation</seealso>
        Task<GetCelebrityInfoResponse> GetCelebrityInfoAsync(GetCelebrityInfoRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetCelebrityRecognition


        /// <summary>
        /// Gets the celebrity recognition results for a Amazon Rekognition Video analysis started
        /// by .
        /// 
        ///  
        /// <para>
        /// Celebrity recognition in a video is an asynchronous operation. Analysis is started
        /// by a call to which returns a job identifier (<code>JobId</code>). When the celebrity
        /// recognition operation finishes, Amazon Rekognition Video publishes a completion status
        /// to the Amazon Simple Notification Service topic registered in the initial call to
        /// <code>StartCelebrityRecognition</code>. To get the results of the celebrity recognition
        /// analysis, first check that the status value published to the Amazon SNS topic is <code>SUCCEEDED</code>.
        /// If so, call <code>GetCelebrityDetection</code> and pass the job identifier (<code>JobId</code>)
        /// from the initial call to <code>StartCelebrityDetection</code>. 
        /// </para>
        ///  
        /// <para>
        /// For more information, see Working With Stored Videos in the Amazon Rekognition Developer
        /// Guide.
        /// </para>
        ///  
        /// <para>
        ///  <code>GetCelebrityRecognition</code> returns detected celebrities and the time(s)
        /// they are detected in an array (<code>Celebrities</code>) of objects. Each <code>CelebrityRecognition</code>
        /// contains information about the celebrity in a object and the time, <code>Timestamp</code>,
        /// the celebrity was detected. 
        /// </para>
        ///  <note> 
        /// <para>
        ///  <code>GetCelebrityRecognition</code> only returns the default facial attributes (<code>BoundingBox</code>,
        /// <code>Confidence</code>, <code>Landmarks</code>, <code>Pose</code>, and <code>Quality</code>).
        /// The other facial attributes listed in the <code>Face</code> object of the following
        /// response syntax are not returned. For more information, see FaceDetail in the Amazon
        /// Rekognition Developer Guide. 
        /// </para>
        ///  </note> 
        /// <para>
        /// By default, the <code>Celebrities</code> array is sorted by time (milliseconds from
        /// the start of the video). You can also sort the array by celebrity by specifying the
        /// value <code>ID</code> in the <code>SortBy</code> input parameter.
        /// </para>
        ///  
        /// <para>
        /// The <code>CelebrityDetail</code> object includes the celebrity identifer and additional
        /// information urls. If you don't store the additional information urls, you can get
        /// them later by calling with the celebrity identifer.
        /// </para>
        ///  
        /// <para>
        /// No information is returned for faces not recognized as celebrities.
        /// </para>
        ///  
        /// <para>
        /// Use MaxResults parameter to limit the number of labels returned. If there are more
        /// results than specified in <code>MaxResults</code>, the value of <code>NextToken</code>
        /// in the operation response contains a pagination token for getting the next set of
        /// results. To get the next page of results, call <code>GetCelebrityDetection</code>
        /// and populate the <code>NextToken</code> request parameter with the token value returned
        /// from the previous call to <code>GetCelebrityRecognition</code>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCelebrityRecognition service method.</param>
        /// 
        /// <returns>The response from the GetCelebrityRecognition service method, as returned by Rekognition.</returns>
        /// <exception cref="Amazon.Rekognition.Model.AccessDeniedException">
        /// You are not authorized to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.InternalServerErrorException">
        /// Amazon Rekognition experienced a service issue. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.InvalidPaginationTokenException">
        /// Pagination token in the request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.InvalidParameterException">
        /// Input parameter violated a constraint. Validate your parameter before calling the
        /// API operation again.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ProvisionedThroughputExceededException">
        /// The number of requests exceeded your throughput limit. If you want to increase this
        /// limit, contact Amazon Rekognition.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ResourceNotFoundException">
        /// The collection specified in the request cannot be found.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ThrottlingException">
        /// Amazon Rekognition is temporarily unable to process the request. Try your call again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rekognition-2016-06-27/GetCelebrityRecognition">REST API Reference for GetCelebrityRecognition Operation</seealso>
        GetCelebrityRecognitionResponse GetCelebrityRecognition(GetCelebrityRecognitionRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the GetCelebrityRecognition operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetCelebrityRecognition operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rekognition-2016-06-27/GetCelebrityRecognition">REST API Reference for GetCelebrityRecognition Operation</seealso>
        Task<GetCelebrityRecognitionResponse> GetCelebrityRecognitionAsync(GetCelebrityRecognitionRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetContentModeration


        /// <summary>
        /// Gets the content moderation analysis results for a Amazon Rekognition Video analysis
        /// started by .
        /// 
        ///  
        /// <para>
        /// Content moderation analysis of a video is an asynchronous operation. You start analysis
        /// by calling . which returns a job identifier (<code>JobId</code>). When analysis finishes,
        /// Amazon Rekognition Video publishes a completion status to the Amazon Simple Notification
        /// Service topic registered in the initial call to <code>StartContentModeration</code>.
        /// To get the results of the content moderation analysis, first check that the status
        /// value published to the Amazon SNS topic is <code>SUCCEEDED</code>. If so, call <code>GetCelebrityDetection</code>
        /// and pass the job identifier (<code>JobId</code>) from the initial call to <code>StartCelebrityDetection</code>.
        /// 
        /// </para>
        ///  
        /// <para>
        /// For more information, see Working with Stored Videos in the Amazon Rekognition Devlopers
        /// Guide.
        /// </para>
        ///  
        /// <para>
        ///  <code>GetContentModeration</code> returns detected content moderation labels, and
        /// the time they are detected, in an array, <code>ModerationLabels</code>, of objects.
        /// 
        /// </para>
        ///  
        /// <para>
        /// By default, the moderated labels are returned sorted by time, in milliseconds from
        /// the start of the video. You can also sort them by moderated label by specifying <code>NAME</code>
        /// for the <code>SortBy</code> input parameter. 
        /// </para>
        ///  
        /// <para>
        /// Since video analysis can return a large number of results, use the <code>MaxResults</code>
        /// parameter to limit the number of labels returned in a single call to <code>GetContentModeration</code>.
        /// If there are more results than specified in <code>MaxResults</code>, the value of
        /// <code>NextToken</code> in the operation response contains a pagination token for getting
        /// the next set of results. To get the next page of results, call <code>GetContentModeration</code>
        /// and populate the <code>NextToken</code> request parameter with the value of <code>NextToken</code>
        /// returned from the previous call to <code>GetContentModeration</code>.
        /// </para>
        ///  
        /// <para>
        /// For more information, see Detecting Unsafe Content in the Amazon Rekognition Developer
        /// Guide.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetContentModeration service method.</param>
        /// 
        /// <returns>The response from the GetContentModeration service method, as returned by Rekognition.</returns>
        /// <exception cref="Amazon.Rekognition.Model.AccessDeniedException">
        /// You are not authorized to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.InternalServerErrorException">
        /// Amazon Rekognition experienced a service issue. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.InvalidPaginationTokenException">
        /// Pagination token in the request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.InvalidParameterException">
        /// Input parameter violated a constraint. Validate your parameter before calling the
        /// API operation again.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ProvisionedThroughputExceededException">
        /// The number of requests exceeded your throughput limit. If you want to increase this
        /// limit, contact Amazon Rekognition.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ResourceNotFoundException">
        /// The collection specified in the request cannot be found.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ThrottlingException">
        /// Amazon Rekognition is temporarily unable to process the request. Try your call again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rekognition-2016-06-27/GetContentModeration">REST API Reference for GetContentModeration Operation</seealso>
        GetContentModerationResponse GetContentModeration(GetContentModerationRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the GetContentModeration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetContentModeration operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rekognition-2016-06-27/GetContentModeration">REST API Reference for GetContentModeration Operation</seealso>
        Task<GetContentModerationResponse> GetContentModerationAsync(GetContentModerationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetFaceDetection


        /// <summary>
        /// Gets face detection results for a Amazon Rekognition Video analysis started by .
        /// 
        ///  
        /// <para>
        /// Face detection with Amazon Rekognition Video is an asynchronous operation. You start
        /// face detection by calling which returns a job identifier (<code>JobId</code>). When
        /// the face detection operation finishes, Amazon Rekognition Video publishes a completion
        /// status to the Amazon Simple Notification Service topic registered in the initial call
        /// to <code>StartFaceDetection</code>. To get the results of the face detection operation,
        /// first check that the status value published to the Amazon SNS topic is <code>SUCCEEDED</code>.
        /// If so, call and pass the job identifier (<code>JobId</code>) from the initial call
        /// to <code>StartFaceDetection</code>.
        /// </para>
        ///  
        /// <para>
        ///  <code>GetFaceDetection</code> returns an array of detected faces (<code>Faces</code>)
        /// sorted by the time the faces were detected. 
        /// </para>
        ///  
        /// <para>
        /// Use MaxResults parameter to limit the number of labels returned. If there are more
        /// results than specified in <code>MaxResults</code>, the value of <code>NextToken</code>
        /// in the operation response contains a pagination token for getting the next set of
        /// results. To get the next page of results, call <code>GetFaceDetection</code> and populate
        /// the <code>NextToken</code> request parameter with the token value returned from the
        /// previous call to <code>GetFaceDetection</code>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetFaceDetection service method.</param>
        /// 
        /// <returns>The response from the GetFaceDetection service method, as returned by Rekognition.</returns>
        /// <exception cref="Amazon.Rekognition.Model.AccessDeniedException">
        /// You are not authorized to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.InternalServerErrorException">
        /// Amazon Rekognition experienced a service issue. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.InvalidPaginationTokenException">
        /// Pagination token in the request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.InvalidParameterException">
        /// Input parameter violated a constraint. Validate your parameter before calling the
        /// API operation again.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ProvisionedThroughputExceededException">
        /// The number of requests exceeded your throughput limit. If you want to increase this
        /// limit, contact Amazon Rekognition.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ResourceNotFoundException">
        /// The collection specified in the request cannot be found.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ThrottlingException">
        /// Amazon Rekognition is temporarily unable to process the request. Try your call again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rekognition-2016-06-27/GetFaceDetection">REST API Reference for GetFaceDetection Operation</seealso>
        GetFaceDetectionResponse GetFaceDetection(GetFaceDetectionRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the GetFaceDetection operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetFaceDetection operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rekognition-2016-06-27/GetFaceDetection">REST API Reference for GetFaceDetection Operation</seealso>
        Task<GetFaceDetectionResponse> GetFaceDetectionAsync(GetFaceDetectionRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetFaceSearch


        /// <summary>
        /// Gets the face search results for Amazon Rekognition Video face search started by .
        /// The search returns faces in a collection that match the faces of persons detected
        /// in a video. It also includes the time(s) that faces are matched in the video.
        /// 
        ///  
        /// <para>
        /// Face search in a video is an asynchronous operation. You start face search by calling
        /// to which returns a job identifier (<code>JobId</code>). When the search operation
        /// finishes, Amazon Rekognition Video publishes a completion status to the Amazon Simple
        /// Notification Service topic registered in the initial call to <code>StartFaceSearch</code>.
        /// To get the search results, first check that the status value published to the Amazon
        /// SNS topic is <code>SUCCEEDED</code>. If so, call <code>GetFaceSearch</code> and pass
        /// the job identifier (<code>JobId</code>) from the initial call to <code>StartFaceSearch</code>.
        /// </para>
        ///  
        /// <para>
        /// For more information, see Searching Faces in a Collection in the Amazon Rekognition
        /// Developer Guide.
        /// </para>
        ///  
        /// <para>
        /// The search results are retured in an array, <code>Persons</code>, of objects. Each<code>PersonMatch</code>
        /// element contains details about the matching faces in the input collection, person
        /// information (facial attributes, bounding boxes, and person identifer) for the matched
        /// person, and the time the person was matched in the video.
        /// </para>
        ///  <note> 
        /// <para>
        ///  <code>GetFaceSearch</code> only returns the default facial attributes (<code>BoundingBox</code>,
        /// <code>Confidence</code>, <code>Landmarks</code>, <code>Pose</code>, and <code>Quality</code>).
        /// The other facial attributes listed in the <code>Face</code> object of the following
        /// response syntax are not returned. For more information, see FaceDetail in the Amazon
        /// Rekognition Developer Guide. 
        /// </para>
        ///  </note> 
        /// <para>
        /// By default, the <code>Persons</code> array is sorted by the time, in milliseconds
        /// from the start of the video, persons are matched. You can also sort by persons by
        /// specifying <code>INDEX</code> for the <code>SORTBY</code> input parameter.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetFaceSearch service method.</param>
        /// 
        /// <returns>The response from the GetFaceSearch service method, as returned by Rekognition.</returns>
        /// <exception cref="Amazon.Rekognition.Model.AccessDeniedException">
        /// You are not authorized to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.InternalServerErrorException">
        /// Amazon Rekognition experienced a service issue. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.InvalidPaginationTokenException">
        /// Pagination token in the request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.InvalidParameterException">
        /// Input parameter violated a constraint. Validate your parameter before calling the
        /// API operation again.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ProvisionedThroughputExceededException">
        /// The number of requests exceeded your throughput limit. If you want to increase this
        /// limit, contact Amazon Rekognition.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ResourceNotFoundException">
        /// The collection specified in the request cannot be found.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ThrottlingException">
        /// Amazon Rekognition is temporarily unable to process the request. Try your call again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rekognition-2016-06-27/GetFaceSearch">REST API Reference for GetFaceSearch Operation</seealso>
        GetFaceSearchResponse GetFaceSearch(GetFaceSearchRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the GetFaceSearch operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetFaceSearch operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rekognition-2016-06-27/GetFaceSearch">REST API Reference for GetFaceSearch Operation</seealso>
        Task<GetFaceSearchResponse> GetFaceSearchAsync(GetFaceSearchRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetLabelDetection


        /// <summary>
        /// Gets the label detection results of a Amazon Rekognition Video analysis started by
        /// . 
        /// 
        ///  
        /// <para>
        /// The label detection operation is started by a call to which returns a job identifier
        /// (<code>JobId</code>). When the label detection operation finishes, Amazon Rekognition
        /// publishes a completion status to the Amazon Simple Notification Service topic registered
        /// in the initial call to <code>StartlabelDetection</code>. To get the results of the
        /// label detection operation, first check that the status value published to the Amazon
        /// SNS topic is <code>SUCCEEDED</code>. If so, call and pass the job identifier (<code>JobId</code>)
        /// from the initial call to <code>StartLabelDetection</code>.
        /// </para>
        ///  
        /// <para>
        ///  <code>GetLabelDetection</code> returns an array of detected labels (<code>Labels</code>)
        /// sorted by the time the labels were detected. You can also sort by the label name by
        /// specifying <code>NAME</code> for the <code>SortBy</code> input parameter.
        /// </para>
        ///  
        /// <para>
        /// The labels returned include the label name, the percentage confidence in the accuracy
        /// of the detected label, and the time the label was detected in the video.
        /// </para>
        ///  
        /// <para>
        /// Use MaxResults parameter to limit the number of labels returned. If there are more
        /// results than specified in <code>MaxResults</code>, the value of <code>NextToken</code>
        /// in the operation response contains a pagination token for getting the next set of
        /// results. To get the next page of results, call <code>GetlabelDetection</code> and
        /// populate the <code>NextToken</code> request parameter with the token value returned
        /// from the previous call to <code>GetLabelDetection</code>.
        /// </para>
        ///  <note> 
        /// <para>
        ///  <code>GetLabelDetection</code> doesn't return a hierarchical taxonomy, or bounding
        /// box information, for detected labels. <code>GetLabelDetection</code> returns <code>null</code>
        /// for the <code>Parents</code> and <code>Instances</code> attributes of the object which
        /// is returned in the <code>Labels</code> array. 
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetLabelDetection service method.</param>
        /// 
        /// <returns>The response from the GetLabelDetection service method, as returned by Rekognition.</returns>
        /// <exception cref="Amazon.Rekognition.Model.AccessDeniedException">
        /// You are not authorized to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.InternalServerErrorException">
        /// Amazon Rekognition experienced a service issue. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.InvalidPaginationTokenException">
        /// Pagination token in the request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.InvalidParameterException">
        /// Input parameter violated a constraint. Validate your parameter before calling the
        /// API operation again.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ProvisionedThroughputExceededException">
        /// The number of requests exceeded your throughput limit. If you want to increase this
        /// limit, contact Amazon Rekognition.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ResourceNotFoundException">
        /// The collection specified in the request cannot be found.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ThrottlingException">
        /// Amazon Rekognition is temporarily unable to process the request. Try your call again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rekognition-2016-06-27/GetLabelDetection">REST API Reference for GetLabelDetection Operation</seealso>
        GetLabelDetectionResponse GetLabelDetection(GetLabelDetectionRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the GetLabelDetection operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetLabelDetection operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rekognition-2016-06-27/GetLabelDetection">REST API Reference for GetLabelDetection Operation</seealso>
        Task<GetLabelDetectionResponse> GetLabelDetectionAsync(GetLabelDetectionRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetPersonTracking


        /// <summary>
        /// Gets the path tracking results of a Amazon Rekognition Video analysis started by .
        /// 
        ///  
        /// <para>
        /// The person path tracking operation is started by a call to <code>StartPersonTracking</code>
        /// which returns a job identifier (<code>JobId</code>). When the operation finishes,
        /// Amazon Rekognition Video publishes a completion status to the Amazon Simple Notification
        /// Service topic registered in the initial call to <code>StartPersonTracking</code>.
        /// </para>
        ///  
        /// <para>
        /// To get the results of the person path tracking operation, first check that the status
        /// value published to the Amazon SNS topic is <code>SUCCEEDED</code>. If so, call and
        /// pass the job identifier (<code>JobId</code>) from the initial call to <code>StartPersonTracking</code>.
        /// </para>
        ///  
        /// <para>
        ///  <code>GetPersonTracking</code> returns an array, <code>Persons</code>, of tracked
        /// persons and the time(s) their paths were tracked in the video. 
        /// </para>
        ///  <note> 
        /// <para>
        ///  <code>GetPersonTracking</code> only returns the default facial attributes (<code>BoundingBox</code>,
        /// <code>Confidence</code>, <code>Landmarks</code>, <code>Pose</code>, and <code>Quality</code>).
        /// The other facial attributes listed in the <code>Face</code> object of the following
        /// response syntax are not returned. 
        /// </para>
        ///  
        /// <para>
        /// For more information, see FaceDetail in the Amazon Rekognition Developer Guide.
        /// </para>
        ///  </note> 
        /// <para>
        /// By default, the array is sorted by the time(s) a person's path is tracked in the video.
        /// You can sort by tracked persons by specifying <code>INDEX</code> for the <code>SortBy</code>
        /// input parameter.
        /// </para>
        ///  
        /// <para>
        /// Use the <code>MaxResults</code> parameter to limit the number of items returned. If
        /// there are more results than specified in <code>MaxResults</code>, the value of <code>NextToken</code>
        /// in the operation response contains a pagination token for getting the next set of
        /// results. To get the next page of results, call <code>GetPersonTracking</code> and
        /// populate the <code>NextToken</code> request parameter with the token value returned
        /// from the previous call to <code>GetPersonTracking</code>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetPersonTracking service method.</param>
        /// 
        /// <returns>The response from the GetPersonTracking service method, as returned by Rekognition.</returns>
        /// <exception cref="Amazon.Rekognition.Model.AccessDeniedException">
        /// You are not authorized to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.InternalServerErrorException">
        /// Amazon Rekognition experienced a service issue. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.InvalidPaginationTokenException">
        /// Pagination token in the request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.InvalidParameterException">
        /// Input parameter violated a constraint. Validate your parameter before calling the
        /// API operation again.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ProvisionedThroughputExceededException">
        /// The number of requests exceeded your throughput limit. If you want to increase this
        /// limit, contact Amazon Rekognition.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ResourceNotFoundException">
        /// The collection specified in the request cannot be found.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ThrottlingException">
        /// Amazon Rekognition is temporarily unable to process the request. Try your call again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rekognition-2016-06-27/GetPersonTracking">REST API Reference for GetPersonTracking Operation</seealso>
        GetPersonTrackingResponse GetPersonTracking(GetPersonTrackingRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the GetPersonTracking operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetPersonTracking operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rekognition-2016-06-27/GetPersonTracking">REST API Reference for GetPersonTracking Operation</seealso>
        Task<GetPersonTrackingResponse> GetPersonTrackingAsync(GetPersonTrackingRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  IndexFaces


        /// <summary>
        /// Detects faces in the input image and adds them to the specified collection. 
        /// 
        ///  
        /// <para>
        /// Amazon Rekognition doesn't save the actual faces that are detected. Instead, the underlying
        /// detection algorithm first detects the faces in the input image. For each face, the
        /// algorithm extracts facial features into a feature vector, and stores it in the backend
        /// database. Amazon Rekognition uses feature vectors when it performs face match and
        /// search operations using the and operations.
        /// </para>
        ///  
        /// <para>
        /// For more information, see Adding Faces to a Collection in the Amazon Rekognition Developer
        /// Guide.
        /// </para>
        ///  
        /// <para>
        /// To get the number of faces in a collection, call . 
        /// </para>
        ///  
        /// <para>
        /// If you're using version 1.0 of the face detection model, <code>IndexFaces</code> indexes
        /// the 15 largest faces in the input image. Later versions of the face detection model
        /// index the 100 largest faces in the input image. 
        /// </para>
        ///  
        /// <para>
        /// If you're using version 4 or later of the face model, image orientation information
        /// is not returned in the <code>OrientationCorrection</code> field. 
        /// </para>
        ///  
        /// <para>
        /// To determine which version of the model you're using, call and supply the collection
        /// ID. You can also get the model version from the value of <code>FaceModelVersion</code>
        /// in the response from <code>IndexFaces</code> 
        /// </para>
        ///  
        /// <para>
        /// For more information, see Model Versioning in the Amazon Rekognition Developer Guide.
        /// </para>
        ///  
        /// <para>
        /// If you provide the optional <code>ExternalImageID</code> for the input image you provided,
        /// Amazon Rekognition associates this ID with all faces that it detects. When you call
        /// the operation, the response returns the external ID. You can use this external image
        /// ID to create a client-side index to associate the faces with each image. You can then
        /// use the index to find all faces in an image.
        /// </para>
        ///  
        /// <para>
        /// You can specify the maximum number of faces to index with the <code>MaxFaces</code>
        /// input parameter. This is useful when you want to index the largest faces in an image
        /// and don't want to index smaller faces, such as those belonging to people standing
        /// in the background.
        /// </para>
        ///  
        /// <para>
        /// The <code>QualityFilter</code> input parameter allows you to filter out detected faces
        /// that don’t meet the required quality bar chosen by Amazon Rekognition. The quality
        /// bar is based on a variety of common use cases. By default, <code>IndexFaces</code>
        /// filters detected faces. You can also explicitly filter detected faces by specifying
        /// <code>AUTO</code> for the value of <code>QualityFilter</code>. If you do not want
        /// to filter detected faces, specify <code>NONE</code>. 
        /// </para>
        ///  <note> 
        /// <para>
        /// To use quality filtering, you need a collection associated with version 3 of the face
        /// model. To get the version of the face model associated with a collection, call . 
        /// </para>
        ///  </note> 
        /// <para>
        /// Information about faces detected in an image, but not indexed, is returned in an array
        /// of objects, <code>UnindexedFaces</code>. Faces aren't indexed for reasons such as:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The number of faces detected exceeds the value of the <code>MaxFaces</code> request
        /// parameter.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The face is too small compared to the image dimensions.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The face is too blurry.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The image is too dark.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The face has an extreme pose.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// In response, the <code>IndexFaces</code> operation returns an array of metadata for
        /// all detected faces, <code>FaceRecords</code>. This includes: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The bounding box, <code>BoundingBox</code>, of the detected face. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A confidence value, <code>Confidence</code>, which indicates the confidence that the
        /// bounding box contains a face.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A face ID, <code>faceId</code>, assigned by the service for each face that's detected
        /// and stored.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// An image ID, <code>ImageId</code>, assigned by the service for the input image.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// If you request all facial attributes (by using the <code>detectionAttributes</code>
        /// parameter), Amazon Rekognition returns detailed facial attributes, such as facial
        /// landmarks (for example, location of eye and mouth) and other facial attributes like
        /// gender. If you provide the same image, specify the same collection, and use the same
        /// external ID in the <code>IndexFaces</code> operation, Amazon Rekognition doesn't save
        /// duplicate face metadata.
        /// </para>
        ///   
        /// <para>
        /// The input image is passed either as base64-encoded image bytes, or as a reference
        /// to an image in an Amazon S3 bucket. If you use the AWS CLI to call Amazon Rekognition
        /// operations, passing image bytes isn't supported. The image must be formatted as a
        /// PNG or JPEG file. 
        /// </para>
        ///  
        /// <para>
        /// This operation requires permissions to perform the <code>rekognition:IndexFaces</code>
        /// action.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the IndexFaces service method.</param>
        /// 
        /// <returns>The response from the IndexFaces service method, as returned by Rekognition.</returns>
        /// <exception cref="Amazon.Rekognition.Model.AccessDeniedException">
        /// You are not authorized to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ImageTooLargeException">
        /// The input image size exceeds the allowed limit. For more information, see Limits in
        /// Amazon Rekognition in the Amazon Rekognition Developer Guide.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.InternalServerErrorException">
        /// Amazon Rekognition experienced a service issue. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.InvalidImageFormatException">
        /// The provided image format is not supported.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.InvalidParameterException">
        /// Input parameter violated a constraint. Validate your parameter before calling the
        /// API operation again.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.InvalidS3ObjectException">
        /// Amazon Rekognition is unable to access the S3 object specified in the request.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ProvisionedThroughputExceededException">
        /// The number of requests exceeded your throughput limit. If you want to increase this
        /// limit, contact Amazon Rekognition.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ResourceNotFoundException">
        /// The collection specified in the request cannot be found.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ThrottlingException">
        /// Amazon Rekognition is temporarily unable to process the request. Try your call again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rekognition-2016-06-27/IndexFaces">REST API Reference for IndexFaces Operation</seealso>
        IndexFacesResponse IndexFaces(IndexFacesRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the IndexFaces operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the IndexFaces operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rekognition-2016-06-27/IndexFaces">REST API Reference for IndexFaces Operation</seealso>
        Task<IndexFacesResponse> IndexFacesAsync(IndexFacesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListCollections


        /// <summary>
        /// Returns list of collection IDs in your account. If the result is truncated, the response
        /// also provides a <code>NextToken</code> that you can use in the subsequent request
        /// to fetch the next set of collection IDs.
        /// 
        ///  
        /// <para>
        /// For an example, see Listing Collections in the Amazon Rekognition Developer Guide.
        /// </para>
        ///  
        /// <para>
        /// This operation requires permissions to perform the <code>rekognition:ListCollections</code>
        /// action.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListCollections service method.</param>
        /// 
        /// <returns>The response from the ListCollections service method, as returned by Rekognition.</returns>
        /// <exception cref="Amazon.Rekognition.Model.AccessDeniedException">
        /// You are not authorized to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.InternalServerErrorException">
        /// Amazon Rekognition experienced a service issue. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.InvalidPaginationTokenException">
        /// Pagination token in the request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.InvalidParameterException">
        /// Input parameter violated a constraint. Validate your parameter before calling the
        /// API operation again.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ProvisionedThroughputExceededException">
        /// The number of requests exceeded your throughput limit. If you want to increase this
        /// limit, contact Amazon Rekognition.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ResourceNotFoundException">
        /// The collection specified in the request cannot be found.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ThrottlingException">
        /// Amazon Rekognition is temporarily unable to process the request. Try your call again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rekognition-2016-06-27/ListCollections">REST API Reference for ListCollections Operation</seealso>
        ListCollectionsResponse ListCollections(ListCollectionsRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the ListCollections operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListCollections operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rekognition-2016-06-27/ListCollections">REST API Reference for ListCollections Operation</seealso>
        Task<ListCollectionsResponse> ListCollectionsAsync(ListCollectionsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListFaces


        /// <summary>
        /// Returns metadata for faces in the specified collection. This metadata includes information
        /// such as the bounding box coordinates, the confidence (that the bounding box contains
        /// a face), and face ID. For an example, see Listing Faces in a Collection in the Amazon
        /// Rekognition Developer Guide.
        /// 
        ///  
        /// <para>
        /// This operation requires permissions to perform the <code>rekognition:ListFaces</code>
        /// action.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListFaces service method.</param>
        /// 
        /// <returns>The response from the ListFaces service method, as returned by Rekognition.</returns>
        /// <exception cref="Amazon.Rekognition.Model.AccessDeniedException">
        /// You are not authorized to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.InternalServerErrorException">
        /// Amazon Rekognition experienced a service issue. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.InvalidPaginationTokenException">
        /// Pagination token in the request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.InvalidParameterException">
        /// Input parameter violated a constraint. Validate your parameter before calling the
        /// API operation again.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ProvisionedThroughputExceededException">
        /// The number of requests exceeded your throughput limit. If you want to increase this
        /// limit, contact Amazon Rekognition.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ResourceNotFoundException">
        /// The collection specified in the request cannot be found.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ThrottlingException">
        /// Amazon Rekognition is temporarily unable to process the request. Try your call again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rekognition-2016-06-27/ListFaces">REST API Reference for ListFaces Operation</seealso>
        ListFacesResponse ListFaces(ListFacesRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the ListFaces operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListFaces operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rekognition-2016-06-27/ListFaces">REST API Reference for ListFaces Operation</seealso>
        Task<ListFacesResponse> ListFacesAsync(ListFacesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListStreamProcessors


        /// <summary>
        /// Gets a list of stream processors that you have created with .
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListStreamProcessors service method.</param>
        /// 
        /// <returns>The response from the ListStreamProcessors service method, as returned by Rekognition.</returns>
        /// <exception cref="Amazon.Rekognition.Model.AccessDeniedException">
        /// You are not authorized to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.InternalServerErrorException">
        /// Amazon Rekognition experienced a service issue. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.InvalidPaginationTokenException">
        /// Pagination token in the request is not valid.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.InvalidParameterException">
        /// Input parameter violated a constraint. Validate your parameter before calling the
        /// API operation again.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ProvisionedThroughputExceededException">
        /// The number of requests exceeded your throughput limit. If you want to increase this
        /// limit, contact Amazon Rekognition.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ThrottlingException">
        /// Amazon Rekognition is temporarily unable to process the request. Try your call again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rekognition-2016-06-27/ListStreamProcessors">REST API Reference for ListStreamProcessors Operation</seealso>
        ListStreamProcessorsResponse ListStreamProcessors(ListStreamProcessorsRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the ListStreamProcessors operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListStreamProcessors operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rekognition-2016-06-27/ListStreamProcessors">REST API Reference for ListStreamProcessors Operation</seealso>
        Task<ListStreamProcessorsResponse> ListStreamProcessorsAsync(ListStreamProcessorsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  RecognizeCelebrities


        /// <summary>
        /// Returns an array of celebrities recognized in the input image. For more information,
        /// see Recognizing Celebrities in the Amazon Rekognition Developer Guide. 
        /// 
        ///  
        /// <para>
        ///  <code>RecognizeCelebrities</code> returns the 100 largest faces in the image. It
        /// lists recognized celebrities in the <code>CelebrityFaces</code> array and unrecognized
        /// faces in the <code>UnrecognizedFaces</code> array. <code>RecognizeCelebrities</code>
        /// doesn't return celebrities whose faces aren't among the largest 100 faces in the image.
        /// </para>
        ///  
        /// <para>
        /// For each celebrity recognized, <code>RecognizeCelebrities</code> returns a <code>Celebrity</code>
        /// object. The <code>Celebrity</code> object contains the celebrity name, ID, URL links
        /// to additional information, match confidence, and a <code>ComparedFace</code> object
        /// that you can use to locate the celebrity's face on the image.
        /// </para>
        ///  
        /// <para>
        /// Amazon Rekognition doesn't retain information about which images a celebrity has been
        /// recognized in. Your application must store this information and use the <code>Celebrity</code>
        /// ID property as a unique identifier for the celebrity. If you don't store the celebrity
        /// name or additional information URLs returned by <code>RecognizeCelebrities</code>,
        /// you will need the ID to identify the celebrity in a call to the operation.
        /// </para>
        ///  
        /// <para>
        /// You pass the input image either as base64-encoded image bytes or as a reference to
        /// an image in an Amazon S3 bucket. If you use the AWS CLI to call Amazon Rekognition
        /// operations, passing image bytes is not supported. The image must be either a PNG or
        /// JPEG formatted file. 
        /// </para>
        ///  
        /// <para>
        /// For an example, see Recognizing Celebrities in an Image in the Amazon Rekognition
        /// Developer Guide.
        /// </para>
        ///  
        /// <para>
        /// This operation requires permissions to perform the <code>rekognition:RecognizeCelebrities</code>
        /// operation.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RecognizeCelebrities service method.</param>
        /// 
        /// <returns>The response from the RecognizeCelebrities service method, as returned by Rekognition.</returns>
        /// <exception cref="Amazon.Rekognition.Model.AccessDeniedException">
        /// You are not authorized to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ImageTooLargeException">
        /// The input image size exceeds the allowed limit. For more information, see Limits in
        /// Amazon Rekognition in the Amazon Rekognition Developer Guide.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.InternalServerErrorException">
        /// Amazon Rekognition experienced a service issue. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.InvalidImageFormatException">
        /// The provided image format is not supported.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.InvalidImageFormatException">
        /// The provided image format is not supported.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.InvalidParameterException">
        /// Input parameter violated a constraint. Validate your parameter before calling the
        /// API operation again.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.InvalidS3ObjectException">
        /// Amazon Rekognition is unable to access the S3 object specified in the request.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ProvisionedThroughputExceededException">
        /// The number of requests exceeded your throughput limit. If you want to increase this
        /// limit, contact Amazon Rekognition.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ThrottlingException">
        /// Amazon Rekognition is temporarily unable to process the request. Try your call again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rekognition-2016-06-27/RecognizeCelebrities">REST API Reference for RecognizeCelebrities Operation</seealso>
        RecognizeCelebritiesResponse RecognizeCelebrities(RecognizeCelebritiesRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the RecognizeCelebrities operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RecognizeCelebrities operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rekognition-2016-06-27/RecognizeCelebrities">REST API Reference for RecognizeCelebrities Operation</seealso>
        Task<RecognizeCelebritiesResponse> RecognizeCelebritiesAsync(RecognizeCelebritiesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  SearchFaces


        /// <summary>
        /// For a given input face ID, searches for matching faces in the collection the face
        /// belongs to. You get a face ID when you add a face to the collection using the <a>IndexFaces</a>
        /// operation. The operation compares the features of the input face with faces in the
        /// specified collection. 
        /// 
        ///  <note> 
        /// <para>
        /// You can also search faces without indexing faces by using the <code>SearchFacesByImage</code>
        /// operation.
        /// </para>
        ///  </note> 
        /// <para>
        ///  The operation response returns an array of faces that match, ordered by similarity
        /// score with the highest similarity first. More specifically, it is an array of metadata
        /// for each face match that is found. Along with the metadata, the response also includes
        /// a <code>confidence</code> value for each face match, indicating the confidence that
        /// the specific face matches the input face. 
        /// </para>
        ///  
        /// <para>
        /// For an example, see Searching for a Face Using Its Face ID in the Amazon Rekognition
        /// Developer Guide.
        /// </para>
        ///  
        /// <para>
        /// This operation requires permissions to perform the <code>rekognition:SearchFaces</code>
        /// action.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SearchFaces service method.</param>
        /// 
        /// <returns>The response from the SearchFaces service method, as returned by Rekognition.</returns>
        /// <exception cref="Amazon.Rekognition.Model.AccessDeniedException">
        /// You are not authorized to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.InternalServerErrorException">
        /// Amazon Rekognition experienced a service issue. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.InvalidParameterException">
        /// Input parameter violated a constraint. Validate your parameter before calling the
        /// API operation again.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ProvisionedThroughputExceededException">
        /// The number of requests exceeded your throughput limit. If you want to increase this
        /// limit, contact Amazon Rekognition.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ResourceNotFoundException">
        /// The collection specified in the request cannot be found.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ThrottlingException">
        /// Amazon Rekognition is temporarily unable to process the request. Try your call again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rekognition-2016-06-27/SearchFaces">REST API Reference for SearchFaces Operation</seealso>
        SearchFacesResponse SearchFaces(SearchFacesRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the SearchFaces operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SearchFaces operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rekognition-2016-06-27/SearchFaces">REST API Reference for SearchFaces Operation</seealso>
        Task<SearchFacesResponse> SearchFacesAsync(SearchFacesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  SearchFacesByImage


        /// <summary>
        /// For a given input image, first detects the largest face in the image, and then searches
        /// the specified collection for matching faces. The operation compares the features of
        /// the input face with faces in the specified collection. 
        /// 
        ///  <note> 
        /// <para>
        /// To search for all faces in an input image, you might first call the operation, and
        /// then use the face IDs returned in subsequent calls to the operation. 
        /// </para>
        ///  
        /// <para>
        ///  You can also call the <code>DetectFaces</code> operation and use the bounding boxes
        /// in the response to make face crops, which then you can pass in to the <code>SearchFacesByImage</code>
        /// operation. 
        /// </para>
        ///  </note> 
        /// <para>
        /// You pass the input image either as base64-encoded image bytes or as a reference to
        /// an image in an Amazon S3 bucket. If you use the AWS CLI to call Amazon Rekognition
        /// operations, passing image bytes is not supported. The image must be either a PNG or
        /// JPEG formatted file. 
        /// </para>
        ///  
        /// <para>
        ///  The response returns an array of faces that match, ordered by similarity score with
        /// the highest similarity first. More specifically, it is an array of metadata for each
        /// face match found. Along with the metadata, the response also includes a <code>similarity</code>
        /// indicating how similar the face is to the input face. In the response, the operation
        /// also returns the bounding box (and a confidence level that the bounding box contains
        /// a face) of the face that Amazon Rekognition used for the input image. 
        /// </para>
        ///  
        /// <para>
        /// For an example, Searching for a Face Using an Image in the Amazon Rekognition Developer
        /// Guide.
        /// </para>
        ///  
        /// <para>
        /// This operation requires permissions to perform the <code>rekognition:SearchFacesByImage</code>
        /// action.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SearchFacesByImage service method.</param>
        /// 
        /// <returns>The response from the SearchFacesByImage service method, as returned by Rekognition.</returns>
        /// <exception cref="Amazon.Rekognition.Model.AccessDeniedException">
        /// You are not authorized to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ImageTooLargeException">
        /// The input image size exceeds the allowed limit. For more information, see Limits in
        /// Amazon Rekognition in the Amazon Rekognition Developer Guide.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.InternalServerErrorException">
        /// Amazon Rekognition experienced a service issue. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.InvalidImageFormatException">
        /// The provided image format is not supported.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.InvalidParameterException">
        /// Input parameter violated a constraint. Validate your parameter before calling the
        /// API operation again.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.InvalidS3ObjectException">
        /// Amazon Rekognition is unable to access the S3 object specified in the request.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ProvisionedThroughputExceededException">
        /// The number of requests exceeded your throughput limit. If you want to increase this
        /// limit, contact Amazon Rekognition.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ResourceNotFoundException">
        /// The collection specified in the request cannot be found.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ThrottlingException">
        /// Amazon Rekognition is temporarily unable to process the request. Try your call again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rekognition-2016-06-27/SearchFacesByImage">REST API Reference for SearchFacesByImage Operation</seealso>
        SearchFacesByImageResponse SearchFacesByImage(SearchFacesByImageRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the SearchFacesByImage operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SearchFacesByImage operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rekognition-2016-06-27/SearchFacesByImage">REST API Reference for SearchFacesByImage Operation</seealso>
        Task<SearchFacesByImageResponse> SearchFacesByImageAsync(SearchFacesByImageRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  StartCelebrityRecognition


        /// <summary>
        /// Starts asynchronous recognition of celebrities in a stored video.
        /// 
        ///  
        /// <para>
        /// Amazon Rekognition Video can detect celebrities in a video must be stored in an Amazon
        /// S3 bucket. Use <a>Video</a> to specify the bucket name and the filename of the video.
        /// <code>StartCelebrityRecognition</code> returns a job identifier (<code>JobId</code>)
        /// which you use to get the results of the analysis. When celebrity recognition analysis
        /// is finished, Amazon Rekognition Video publishes a completion status to the Amazon
        /// Simple Notification Service topic that you specify in <code>NotificationChannel</code>.
        /// To get the results of the celebrity recognition analysis, first check that the status
        /// value published to the Amazon SNS topic is <code>SUCCEEDED</code>. If so, call and
        /// pass the job identifier (<code>JobId</code>) from the initial call to <code>StartCelebrityRecognition</code>.
        /// 
        /// </para>
        ///  
        /// <para>
        /// For more information, see Recognizing Celebrities in the Amazon Rekognition Developer
        /// Guide.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartCelebrityRecognition service method.</param>
        /// 
        /// <returns>The response from the StartCelebrityRecognition service method, as returned by Rekognition.</returns>
        /// <exception cref="Amazon.Rekognition.Model.AccessDeniedException">
        /// You are not authorized to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.IdempotentParameterMismatchException">
        /// A <code>ClientRequestToken</code> input parameter was reused with an operation, but
        /// at least one of the other input parameters is different from the previous call to
        /// the operation.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.InternalServerErrorException">
        /// Amazon Rekognition experienced a service issue. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.InvalidParameterException">
        /// Input parameter violated a constraint. Validate your parameter before calling the
        /// API operation again.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.InvalidS3ObjectException">
        /// Amazon Rekognition is unable to access the S3 object specified in the request.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.LimitExceededException">
        /// An Amazon Rekognition service limit was exceeded. For example, if you start too many
        /// Amazon Rekognition Video jobs concurrently, calls to start operations (<code>StartLabelDetection</code>,
        /// for example) will raise a <code>LimitExceededException</code> exception (HTTP status
        /// code: 400) until the number of concurrently running jobs is below the Amazon Rekognition
        /// service limit.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ProvisionedThroughputExceededException">
        /// The number of requests exceeded your throughput limit. If you want to increase this
        /// limit, contact Amazon Rekognition.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ThrottlingException">
        /// Amazon Rekognition is temporarily unable to process the request. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.VideoTooLargeException">
        /// The file size or duration of the supplied media is too large. The maximum file size
        /// is 8GB. The maximum duration is 2 hours.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rekognition-2016-06-27/StartCelebrityRecognition">REST API Reference for StartCelebrityRecognition Operation</seealso>
        StartCelebrityRecognitionResponse StartCelebrityRecognition(StartCelebrityRecognitionRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the StartCelebrityRecognition operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartCelebrityRecognition operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rekognition-2016-06-27/StartCelebrityRecognition">REST API Reference for StartCelebrityRecognition Operation</seealso>
        Task<StartCelebrityRecognitionResponse> StartCelebrityRecognitionAsync(StartCelebrityRecognitionRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  StartContentModeration


        /// <summary>
        /// Starts asynchronous detection of explicit or suggestive adult content in a stored
        /// video.
        /// 
        ///  
        /// <para>
        /// Amazon Rekognition Video can moderate content in a video stored in an Amazon S3 bucket.
        /// Use <a>Video</a> to specify the bucket name and the filename of the video. <code>StartContentModeration</code>
        /// returns a job identifier (<code>JobId</code>) which you use to get the results of
        /// the analysis. When content moderation analysis is finished, Amazon Rekognition Video
        /// publishes a completion status to the Amazon Simple Notification Service topic that
        /// you specify in <code>NotificationChannel</code>.
        /// </para>
        ///  
        /// <para>
        /// To get the results of the content moderation analysis, first check that the status
        /// value published to the Amazon SNS topic is <code>SUCCEEDED</code>. If so, call and
        /// pass the job identifier (<code>JobId</code>) from the initial call to <code>StartContentModeration</code>.
        /// 
        /// </para>
        ///  
        /// <para>
        /// For more information, see Detecting Unsafe Content in the Amazon Rekognition Developer
        /// Guide.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartContentModeration service method.</param>
        /// 
        /// <returns>The response from the StartContentModeration service method, as returned by Rekognition.</returns>
        /// <exception cref="Amazon.Rekognition.Model.AccessDeniedException">
        /// You are not authorized to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.IdempotentParameterMismatchException">
        /// A <code>ClientRequestToken</code> input parameter was reused with an operation, but
        /// at least one of the other input parameters is different from the previous call to
        /// the operation.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.InternalServerErrorException">
        /// Amazon Rekognition experienced a service issue. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.InvalidParameterException">
        /// Input parameter violated a constraint. Validate your parameter before calling the
        /// API operation again.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.InvalidS3ObjectException">
        /// Amazon Rekognition is unable to access the S3 object specified in the request.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.LimitExceededException">
        /// An Amazon Rekognition service limit was exceeded. For example, if you start too many
        /// Amazon Rekognition Video jobs concurrently, calls to start operations (<code>StartLabelDetection</code>,
        /// for example) will raise a <code>LimitExceededException</code> exception (HTTP status
        /// code: 400) until the number of concurrently running jobs is below the Amazon Rekognition
        /// service limit.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ProvisionedThroughputExceededException">
        /// The number of requests exceeded your throughput limit. If you want to increase this
        /// limit, contact Amazon Rekognition.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ThrottlingException">
        /// Amazon Rekognition is temporarily unable to process the request. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.VideoTooLargeException">
        /// The file size or duration of the supplied media is too large. The maximum file size
        /// is 8GB. The maximum duration is 2 hours.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rekognition-2016-06-27/StartContentModeration">REST API Reference for StartContentModeration Operation</seealso>
        StartContentModerationResponse StartContentModeration(StartContentModerationRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the StartContentModeration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartContentModeration operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rekognition-2016-06-27/StartContentModeration">REST API Reference for StartContentModeration Operation</seealso>
        Task<StartContentModerationResponse> StartContentModerationAsync(StartContentModerationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  StartFaceDetection


        /// <summary>
        /// Starts asynchronous detection of faces in a stored video.
        /// 
        ///  
        /// <para>
        /// Amazon Rekognition Video can detect faces in a video stored in an Amazon S3 bucket.
        /// Use <a>Video</a> to specify the bucket name and the filename of the video. <code>StartFaceDetection</code>
        /// returns a job identifier (<code>JobId</code>) that you use to get the results of the
        /// operation. When face detection is finished, Amazon Rekognition Video publishes a completion
        /// status to the Amazon Simple Notification Service topic that you specify in <code>NotificationChannel</code>.
        /// To get the results of the face detection operation, first check that the status value
        /// published to the Amazon SNS topic is <code>SUCCEEDED</code>. If so, call and pass
        /// the job identifier (<code>JobId</code>) from the initial call to <code>StartFaceDetection</code>.
        /// </para>
        ///  
        /// <para>
        /// For more information, see Detecting Faces in a Stored Video in the Amazon Rekognition
        /// Developer Guide.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartFaceDetection service method.</param>
        /// 
        /// <returns>The response from the StartFaceDetection service method, as returned by Rekognition.</returns>
        /// <exception cref="Amazon.Rekognition.Model.AccessDeniedException">
        /// You are not authorized to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.IdempotentParameterMismatchException">
        /// A <code>ClientRequestToken</code> input parameter was reused with an operation, but
        /// at least one of the other input parameters is different from the previous call to
        /// the operation.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.InternalServerErrorException">
        /// Amazon Rekognition experienced a service issue. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.InvalidParameterException">
        /// Input parameter violated a constraint. Validate your parameter before calling the
        /// API operation again.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.InvalidS3ObjectException">
        /// Amazon Rekognition is unable to access the S3 object specified in the request.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.LimitExceededException">
        /// An Amazon Rekognition service limit was exceeded. For example, if you start too many
        /// Amazon Rekognition Video jobs concurrently, calls to start operations (<code>StartLabelDetection</code>,
        /// for example) will raise a <code>LimitExceededException</code> exception (HTTP status
        /// code: 400) until the number of concurrently running jobs is below the Amazon Rekognition
        /// service limit.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ProvisionedThroughputExceededException">
        /// The number of requests exceeded your throughput limit. If you want to increase this
        /// limit, contact Amazon Rekognition.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ThrottlingException">
        /// Amazon Rekognition is temporarily unable to process the request. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.VideoTooLargeException">
        /// The file size or duration of the supplied media is too large. The maximum file size
        /// is 8GB. The maximum duration is 2 hours.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rekognition-2016-06-27/StartFaceDetection">REST API Reference for StartFaceDetection Operation</seealso>
        StartFaceDetectionResponse StartFaceDetection(StartFaceDetectionRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the StartFaceDetection operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartFaceDetection operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rekognition-2016-06-27/StartFaceDetection">REST API Reference for StartFaceDetection Operation</seealso>
        Task<StartFaceDetectionResponse> StartFaceDetectionAsync(StartFaceDetectionRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  StartFaceSearch


        /// <summary>
        /// Starts the asynchronous search for faces in a collection that match the faces of persons
        /// detected in a stored video.
        /// 
        ///  
        /// <para>
        /// The video must be stored in an Amazon S3 bucket. Use <a>Video</a> to specify the bucket
        /// name and the filename of the video. <code>StartFaceSearch</code> returns a job identifier
        /// (<code>JobId</code>) which you use to get the search results once the search has completed.
        /// When searching is finished, Amazon Rekognition Video publishes a completion status
        /// to the Amazon Simple Notification Service topic that you specify in <code>NotificationChannel</code>.
        /// To get the search results, first check that the status value published to the Amazon
        /// SNS topic is <code>SUCCEEDED</code>. If so, call and pass the job identifier (<code>JobId</code>)
        /// from the initial call to <code>StartFaceSearch</code>. For more information, see <a>procedure-person-search-videos</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartFaceSearch service method.</param>
        /// 
        /// <returns>The response from the StartFaceSearch service method, as returned by Rekognition.</returns>
        /// <exception cref="Amazon.Rekognition.Model.AccessDeniedException">
        /// You are not authorized to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.IdempotentParameterMismatchException">
        /// A <code>ClientRequestToken</code> input parameter was reused with an operation, but
        /// at least one of the other input parameters is different from the previous call to
        /// the operation.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.InternalServerErrorException">
        /// Amazon Rekognition experienced a service issue. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.InvalidParameterException">
        /// Input parameter violated a constraint. Validate your parameter before calling the
        /// API operation again.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.InvalidS3ObjectException">
        /// Amazon Rekognition is unable to access the S3 object specified in the request.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.LimitExceededException">
        /// An Amazon Rekognition service limit was exceeded. For example, if you start too many
        /// Amazon Rekognition Video jobs concurrently, calls to start operations (<code>StartLabelDetection</code>,
        /// for example) will raise a <code>LimitExceededException</code> exception (HTTP status
        /// code: 400) until the number of concurrently running jobs is below the Amazon Rekognition
        /// service limit.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ProvisionedThroughputExceededException">
        /// The number of requests exceeded your throughput limit. If you want to increase this
        /// limit, contact Amazon Rekognition.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ResourceNotFoundException">
        /// The collection specified in the request cannot be found.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ThrottlingException">
        /// Amazon Rekognition is temporarily unable to process the request. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.VideoTooLargeException">
        /// The file size or duration of the supplied media is too large. The maximum file size
        /// is 8GB. The maximum duration is 2 hours.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rekognition-2016-06-27/StartFaceSearch">REST API Reference for StartFaceSearch Operation</seealso>
        StartFaceSearchResponse StartFaceSearch(StartFaceSearchRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the StartFaceSearch operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartFaceSearch operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rekognition-2016-06-27/StartFaceSearch">REST API Reference for StartFaceSearch Operation</seealso>
        Task<StartFaceSearchResponse> StartFaceSearchAsync(StartFaceSearchRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  StartLabelDetection


        /// <summary>
        /// Starts asynchronous detection of labels in a stored video.
        /// 
        ///  
        /// <para>
        /// Amazon Rekognition Video can detect labels in a video. Labels are instances of real-world
        /// entities. This includes objects like flower, tree, and table; events like wedding,
        /// graduation, and birthday party; concepts like landscape, evening, and nature; and
        /// activities like a person getting out of a car or a person skiing.
        /// </para>
        ///  
        /// <para>
        /// The video must be stored in an Amazon S3 bucket. Use <a>Video</a> to specify the bucket
        /// name and the filename of the video. <code>StartLabelDetection</code> returns a job
        /// identifier (<code>JobId</code>) which you use to get the results of the operation.
        /// When label detection is finished, Amazon Rekognition Video publishes a completion
        /// status to the Amazon Simple Notification Service topic that you specify in <code>NotificationChannel</code>.
        /// </para>
        ///  
        /// <para>
        /// To get the results of the label detection operation, first check that the status value
        /// published to the Amazon SNS topic is <code>SUCCEEDED</code>. If so, call and pass
        /// the job identifier (<code>JobId</code>) from the initial call to <code>StartLabelDetection</code>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartLabelDetection service method.</param>
        /// 
        /// <returns>The response from the StartLabelDetection service method, as returned by Rekognition.</returns>
        /// <exception cref="Amazon.Rekognition.Model.AccessDeniedException">
        /// You are not authorized to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.IdempotentParameterMismatchException">
        /// A <code>ClientRequestToken</code> input parameter was reused with an operation, but
        /// at least one of the other input parameters is different from the previous call to
        /// the operation.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.InternalServerErrorException">
        /// Amazon Rekognition experienced a service issue. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.InvalidParameterException">
        /// Input parameter violated a constraint. Validate your parameter before calling the
        /// API operation again.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.InvalidS3ObjectException">
        /// Amazon Rekognition is unable to access the S3 object specified in the request.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.LimitExceededException">
        /// An Amazon Rekognition service limit was exceeded. For example, if you start too many
        /// Amazon Rekognition Video jobs concurrently, calls to start operations (<code>StartLabelDetection</code>,
        /// for example) will raise a <code>LimitExceededException</code> exception (HTTP status
        /// code: 400) until the number of concurrently running jobs is below the Amazon Rekognition
        /// service limit.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ProvisionedThroughputExceededException">
        /// The number of requests exceeded your throughput limit. If you want to increase this
        /// limit, contact Amazon Rekognition.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ThrottlingException">
        /// Amazon Rekognition is temporarily unable to process the request. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.VideoTooLargeException">
        /// The file size or duration of the supplied media is too large. The maximum file size
        /// is 8GB. The maximum duration is 2 hours.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rekognition-2016-06-27/StartLabelDetection">REST API Reference for StartLabelDetection Operation</seealso>
        StartLabelDetectionResponse StartLabelDetection(StartLabelDetectionRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the StartLabelDetection operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartLabelDetection operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rekognition-2016-06-27/StartLabelDetection">REST API Reference for StartLabelDetection Operation</seealso>
        Task<StartLabelDetectionResponse> StartLabelDetectionAsync(StartLabelDetectionRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  StartPersonTracking


        /// <summary>
        /// Starts the asynchronous tracking of a person's path in a stored video.
        /// 
        ///  
        /// <para>
        /// Amazon Rekognition Video can track the path of people in a video stored in an Amazon
        /// S3 bucket. Use <a>Video</a> to specify the bucket name and the filename of the video.
        /// <code>StartPersonTracking</code> returns a job identifier (<code>JobId</code>) which
        /// you use to get the results of the operation. When label detection is finished, Amazon
        /// Rekognition publishes a completion status to the Amazon Simple Notification Service
        /// topic that you specify in <code>NotificationChannel</code>. 
        /// </para>
        ///  
        /// <para>
        /// To get the results of the person detection operation, first check that the status
        /// value published to the Amazon SNS topic is <code>SUCCEEDED</code>. If so, call and
        /// pass the job identifier (<code>JobId</code>) from the initial call to <code>StartPersonTracking</code>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartPersonTracking service method.</param>
        /// 
        /// <returns>The response from the StartPersonTracking service method, as returned by Rekognition.</returns>
        /// <exception cref="Amazon.Rekognition.Model.AccessDeniedException">
        /// You are not authorized to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.IdempotentParameterMismatchException">
        /// A <code>ClientRequestToken</code> input parameter was reused with an operation, but
        /// at least one of the other input parameters is different from the previous call to
        /// the operation.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.InternalServerErrorException">
        /// Amazon Rekognition experienced a service issue. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.InvalidParameterException">
        /// Input parameter violated a constraint. Validate your parameter before calling the
        /// API operation again.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.InvalidS3ObjectException">
        /// Amazon Rekognition is unable to access the S3 object specified in the request.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.LimitExceededException">
        /// An Amazon Rekognition service limit was exceeded. For example, if you start too many
        /// Amazon Rekognition Video jobs concurrently, calls to start operations (<code>StartLabelDetection</code>,
        /// for example) will raise a <code>LimitExceededException</code> exception (HTTP status
        /// code: 400) until the number of concurrently running jobs is below the Amazon Rekognition
        /// service limit.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ProvisionedThroughputExceededException">
        /// The number of requests exceeded your throughput limit. If you want to increase this
        /// limit, contact Amazon Rekognition.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ThrottlingException">
        /// Amazon Rekognition is temporarily unable to process the request. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.VideoTooLargeException">
        /// The file size or duration of the supplied media is too large. The maximum file size
        /// is 8GB. The maximum duration is 2 hours.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rekognition-2016-06-27/StartPersonTracking">REST API Reference for StartPersonTracking Operation</seealso>
        StartPersonTrackingResponse StartPersonTracking(StartPersonTrackingRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the StartPersonTracking operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartPersonTracking operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rekognition-2016-06-27/StartPersonTracking">REST API Reference for StartPersonTracking Operation</seealso>
        Task<StartPersonTrackingResponse> StartPersonTrackingAsync(StartPersonTrackingRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  StartStreamProcessor


        /// <summary>
        /// Starts processing a stream processor. You create a stream processor by calling . To
        /// tell <code>StartStreamProcessor</code> which stream processor to start, use the value
        /// of the <code>Name</code> field specified in the call to <code>CreateStreamProcessor</code>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartStreamProcessor service method.</param>
        /// 
        /// <returns>The response from the StartStreamProcessor service method, as returned by Rekognition.</returns>
        /// <exception cref="Amazon.Rekognition.Model.AccessDeniedException">
        /// You are not authorized to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.InternalServerErrorException">
        /// Amazon Rekognition experienced a service issue. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.InvalidParameterException">
        /// Input parameter violated a constraint. Validate your parameter before calling the
        /// API operation again.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ProvisionedThroughputExceededException">
        /// The number of requests exceeded your throughput limit. If you want to increase this
        /// limit, contact Amazon Rekognition.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ResourceInUseException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ResourceNotFoundException">
        /// The collection specified in the request cannot be found.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ThrottlingException">
        /// Amazon Rekognition is temporarily unable to process the request. Try your call again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rekognition-2016-06-27/StartStreamProcessor">REST API Reference for StartStreamProcessor Operation</seealso>
        StartStreamProcessorResponse StartStreamProcessor(StartStreamProcessorRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the StartStreamProcessor operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartStreamProcessor operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rekognition-2016-06-27/StartStreamProcessor">REST API Reference for StartStreamProcessor Operation</seealso>
        Task<StartStreamProcessorResponse> StartStreamProcessorAsync(StartStreamProcessorRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  StopStreamProcessor


        /// <summary>
        /// Stops a running stream processor that was created by .
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopStreamProcessor service method.</param>
        /// 
        /// <returns>The response from the StopStreamProcessor service method, as returned by Rekognition.</returns>
        /// <exception cref="Amazon.Rekognition.Model.AccessDeniedException">
        /// You are not authorized to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.InternalServerErrorException">
        /// Amazon Rekognition experienced a service issue. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.InvalidParameterException">
        /// Input parameter violated a constraint. Validate your parameter before calling the
        /// API operation again.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ProvisionedThroughputExceededException">
        /// The number of requests exceeded your throughput limit. If you want to increase this
        /// limit, contact Amazon Rekognition.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ResourceInUseException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ResourceNotFoundException">
        /// The collection specified in the request cannot be found.
        /// </exception>
        /// <exception cref="Amazon.Rekognition.Model.ThrottlingException">
        /// Amazon Rekognition is temporarily unable to process the request. Try your call again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rekognition-2016-06-27/StopStreamProcessor">REST API Reference for StopStreamProcessor Operation</seealso>
        StopStreamProcessorResponse StopStreamProcessor(StopStreamProcessorRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the StopStreamProcessor operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StopStreamProcessor operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rekognition-2016-06-27/StopStreamProcessor">REST API Reference for StopStreamProcessor Operation</seealso>
        Task<StopStreamProcessorResponse> StopStreamProcessorAsync(StopStreamProcessorRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
    }
}