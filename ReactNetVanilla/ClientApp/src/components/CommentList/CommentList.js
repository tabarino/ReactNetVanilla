import React from 'react';
import styles from './CommentList.module.css';
import Comment from '../Comment/Comment';

const CommentList = (props) => {
  const commentNodes = props.comments.map(comment => (
    <Comment author={comment.Author} key={comment.Id}>
      {comment.Text}
    </Comment>
  ));

  return (
    <div className={styles.CommentList}>{commentNodes}</div>
  );
}

export default CommentList;
