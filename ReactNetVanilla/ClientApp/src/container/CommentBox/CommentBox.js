import React, { Component } from 'react';
import CommentForm from '../../components/CommentForm/CommentForm';
import CommentList from '../../components/CommentList/CommentList';

export class CommentBox extends Component {
  state = {
    comments: [],
    loading: true
  };

  render() {
    let contents = this.state.loading
      ? <p><em>Loading...</em></p>
      : this.renderComments(this.state.comments);

    return (
      <div>
        <h1>Comments</h1>
        {contents}
      </div>
    );
  }

  renderComments = (comments) => {
    return <CommentList comments={comments} />;
  }

  componentDidMount() {
    this.populateCommentsData();
  }

  async populateCommentsData() {
    const response = await fetch('api/comments');
    const data = await response.json();
    this.setState({ comments: data, loading: false });
  }
}
